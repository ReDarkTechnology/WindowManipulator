using System;
using System.Drawing;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

public static class Utility
{
    static char[] randomMD5 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
    public static List<string> knownMD5 = new List<string>();
    public static string GetMD5()
    {
        Random rand = new Random();
        string build = null;
        for (int i = 0; i < 20; i++)
        {
            build += randomMD5[rand.Next(0, randomMD5.Length - 1)];
        }
        if (knownMD5.Contains(build))
        {
            build = GetMD5();
        }
        knownMD5.Add(build);
        return build;
    }
    public static Color ColorFromString(string str)
    {
        str = str.Remove(0, 1);
        str = str.Remove(str.Length - 1, 1);
        var values = str.Split(",".ToCharArray());
        return Color.FromArgb(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]), int.Parse(values[3]));
    }
    public static string ColorToString(Color color)
    {
        string build = "(";
        build += color.A;
        build += ",";
        build += color.R;
        build += ",";
        build += color.G;
        build += ",";
        build += color.B;
        build += ")";
        return build;
    }
    public static Vector2 Vector2FromString(string str)
    {
        str = str.Remove(0);
        str = str.Remove(str.Length - 1);
        var values = str.Split(",".ToCharArray());
        return new Vector2 (float.Parse(values[0]), float.Parse(values[1]));
    }
    public static string Vector2ToString(Vector2 vector)
    {
        string build = "(";
        build += vector.x;
        build += ",";
        build += vector.y;
        build += ")";
        return build;
    }
    public static Vector2 GetScreenSize(bool squarize = true){
		var screen = new Vector2(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
		if(squarize){
			screen = SquarizeVector(screen);
		}
		return screen;
	}
	public static Vector2 LocalCanvas = new Vector2(1f, 1f);
	public static Vector2 ConvertWorldToLocal(Vector2 world){
		var screen = GetScreenSize();
		var originalScreen = GetScreenSize(false);
		var _add = (originalScreen/screen) / 4;
		var ratio = GetRatio(LocalCanvas, screen);
		return world * (float) ratio;
	}
	public static Vector2 ConvertLocalToWorld(Vector2 local){
		var screen = GetScreenSize();
		var originalScreen = GetScreenSize(false);
		var _add = (originalScreen/screen) / 4;
		var ratio = GetRatio(LocalCanvas, screen);
		var scale = ResizeScreen(LocalCanvas, GetScreenSize());
		return local / (float) ratio;
	}
	public static Vector2 SquarizeVector(Vector2 vector){
		// disable once CompareOfFloatsByEqualityOperator
		if(vector.x < vector.y){
			return new Vector2(vector.x, vector.x);
		}
		if(vector.x > vector.y){
			return new Vector2(vector.y, vector.y);
		}
		return vector;
	}
	public static Vector2 ResizeScreen(Vector2 canvas, Vector2 original)
    {
		double ratio = GetRatio(canvas, original);

        // now we can get the new height and width
        int newHeight = Convert.ToInt32(original.y * ratio);
        int newWidth = Convert.ToInt32(original.x * ratio);
        
        return new Vector2(newWidth, newHeight);
    }
	public static double GetRatio(Vector2 canvas, Vector2 original)
    {
        // Figure out the ratio
        double ratioX = (double)canvas.x / (double)original.x;
        double ratioY = (double)canvas.y / (double)original.y;
        // use whichever multiplier is smaller
        return ratioX < ratioY ? ratioX : ratioY;
    }
	public static string FloatToString(float fr){
		var result = fr.ToString();
		try {
			result = result.Replace((",").ToCharArray()[0], (".").ToCharArray()[0]);
		}catch{
			
		}
		return result;
	}
	public static float StringToFloat(string fr){
		fr = fr.Replace(".", ",");
		return float.Parse(fr);
	}

    public static ListViewItem[] GetSelectedItems(ListView view)
    {
        List<ListViewItem> items = new List<ListViewItem>();
        if (view.SelectedItems.Count > 0)
        {
            foreach (ListViewItem item in view.SelectedItems)
            {
                if (item != null) items.Add(item);
            }
        }
        return items.ToArray();
    }

    public static Control[] GetControls(Control control, bool deep = true)
    {
        List<Control> controll = new List<Control>();
        foreach (Control pb in control.Controls)
        {
            controll.Add(pb);
        }
        if (deep)
        {
            foreach (Control ctrl in control.Controls)
            {
                var controls = GetControls(ctrl);
                foreach (var butt in controls)
                {
                    controll.Add(butt);
                }
            }
        }
        return controll.ToArray();
    }

    public static T[] GetControlsWithType<T>(Control control)
    {
        List<T> controll = new List<T>();
        foreach (object pb in control.Controls)
        {
            if (pb.GetType() == typeof(T))
            {
                controll.Add((T)pb);
            } 
        }
        foreach (Control ctrl in control.Controls)
        {
            var controls = GetControlsWithType<T>(ctrl);
            foreach (object butt in controls)
            {
                controll.Add((T)butt);
            }
        }
        return controll.ToArray();
    }
    #region Encryption
    // This constant is used to determine the keysize of the encryption algorithm in bits.
	// We divide this by 8 within the code below to get the equivalent number of bytes.
	static int Keysize = 256;

	// This constant determines the number of iterations for the password bytes generation function.
	static int DerivationIterations = 1000;

	public static string laPhrase = "passowo";

	public static string Encrypt(string plainText, string passPhrase = null)
	{
		if(string.IsNullOrEmpty(passPhrase)){
			passPhrase = laPhrase;
		}
		// Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
		// so that the same Salt and IV values can be used when decrypting.  
		var saltStringBytes = Generate256BitsOfRandomEntropy();
		var ivStringBytes = Generate256BitsOfRandomEntropy();
		var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
		using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
		{
			var keyBytes = password.GetBytes(Keysize / 8);
			using (var symmetricKey = new RijndaelManaged())
			{
				symmetricKey.BlockSize = 256;
				symmetricKey.Mode = CipherMode.CBC;
				symmetricKey.Padding = PaddingMode.PKCS7;
				using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
				{
					using (var memoryStream = new MemoryStream())
					{
						using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
						{
							cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
							cryptoStream.FlushFinalBlock();
							// Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
							var cipherTextBytes = saltStringBytes;
							cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
							cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
							memoryStream.Close();
							cryptoStream.Close();
							return Convert.ToBase64String(cipherTextBytes);
						}
					}
				}
			}
		}
	}

	public static string Decrypt(string cipherText, string passPhrase = null)
	{	
		if(string.IsNullOrEmpty(passPhrase)){
			passPhrase = laPhrase;
		}
		// Get the complete stream of bytes that represent:
		// [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
		var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
		// Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
		var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
		// Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
		var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
		// Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
		var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

		using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
		{
			var keyBytes = password.GetBytes(Keysize / 8);
			using (var symmetricKey = new RijndaelManaged())
			{
				symmetricKey.BlockSize = 256;
				symmetricKey.Mode = CipherMode.CBC;
				symmetricKey.Padding = PaddingMode.PKCS7;
				using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
				{
					using (var memoryStream = new MemoryStream(cipherTextBytes))
					{
						using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
						{
							var plainTextBytes = new byte[cipherTextBytes.Length];
							var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
							memoryStream.Close();
							cryptoStream.Close();
							return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
						}
					}
				}
			}
		}
	}
	
	private static byte[] Generate256BitsOfRandomEntropy()
	{
		var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
		using (var rngCsp = new RNGCryptoServiceProvider())
		{
			// Fill the array with cryptographically secure random bytes.
			rngCsp.GetBytes(randomBytes);
		}
		return randomBytes;
	}
	public static string Base64Encode(string plainText) {
		var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
		return System.Convert.ToBase64String(plainTextBytes);
	}
	public static string Base64Decode(string base64EncodedData) {
		var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
		return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
	}
	#endregion
	public static byte[] Compress(byte[] data)
	{
	    MemoryStream output = new MemoryStream();
	    using (DeflateStream dstream = new DeflateStream(output, CompressionLevel.Optimal))
	    {
	        dstream.Write(data, 0, data.Length);
	    }
	    return output.ToArray();
	}
	
	public static byte[] Decompress(byte[] data)
	{
	    MemoryStream input = new MemoryStream(data);
	    MemoryStream output = new MemoryStream();
	    using (DeflateStream dstream = new DeflateStream(input, CompressionMode.Decompress))
	    {
	        dstream.CopyTo(output);
	    }
	    return output.ToArray();
	}
}
public enum Space
{
	World,
	Self
}
public enum SendMessageOptions
{
	RequireReceiver,
	DontRequireReceiver
}
public enum PrimitiveType
{
	Sphere,
	Capsule,
	Cylinder,
	Cube,
	Plane,
	Quad
}
internal enum RotationOrder
{
	OrderXYZ,
	OrderXZY,
	OrderYZX,
	OrderYXZ,
	OrderZXY,
	OrderZYX
}
