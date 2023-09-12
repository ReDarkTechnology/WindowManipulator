using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

public class FlagEnumComboBox<TEnum> : ComboBox where TEnum : Enum
{
    public new TEnum SelectedItem
    {
        get
        {
            if (base.SelectedItem is TEnum selectedValue)
                return selectedValue;

            return default;
        }
        set
        {
            if (value.Equals(default(TEnum)))
            {
                base.SelectedItem = null;
                return;
            }

            base.SelectedItem = value;
        }
    }

    public FlagEnumComboBox()
    {
        DrawMode = DrawMode.OwnerDrawFixed;
        DropDownStyle = ComboBoxStyle.DropDownList;
    }

    protected override void OnDrawItem(DrawItemEventArgs e)
    {
        e.DrawBackground();

        if (e.Index >= 0)
        {
            var value = (TEnum)Items[e.Index];
            var displayName = GetEnumDisplayName(value);

            e.Graphics.DrawString(displayName, e.Font, SystemBrushes.ControlText, e.Bounds);
        }

        base.OnDrawItem(e);
    }

    protected override void OnDropDown(EventArgs e)
    {
        RefreshItems();
        base.OnDropDown(e);
    }

    protected override void RefreshItems()
    {
        base.RefreshItems();
        Items.Clear();

        foreach (var value in Enum.GetValues(typeof(TEnum)))
        {
            Items.Add(value);
        }
    }

    private string GetEnumDisplayName(TEnum value)
    {
        var displayName = value.ToString();
        var fieldInfo = typeof(TEnum).GetField(displayName);

        if (fieldInfo != null)
        {
            var attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                displayName = ((DescriptionAttribute)attributes[0]).Description;
            }
        }

        return displayName;
    }
}