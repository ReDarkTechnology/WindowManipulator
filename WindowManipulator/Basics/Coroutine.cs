using System;
using System.Collections.Generic;

public static class Coroutine
{
    public static List<CoroutineQueue> runningQueue = new List<CoroutineQueue>();
    public static List<CoroutineQueue> destroyQueue = new List<CoroutineQueue>();
    public static List<CoroutineQueue> actionReadyQueue = new List<CoroutineQueue>();
    public static bool isInitialized;
    public static void Initialize()
    {
        if (!isInitialized)
        {
            Time.currentTimer.Tick += (e, a) => Update();
            isInitialized = true;
        }

    }
    public static void Update()
    {
        int countTemp = runningQueue.Count;
        for (int i = 0; i < countTemp; i++)
        {
            var item = runningQueue[i];
            if (item != null)
            {
                item.timeRemaining -= Time.deltaTime;
                actionReadyQueue.Add(item);
                if (item.timeRemaining < 0)
                {
                    destroyQueue.Add(item);
                }
            }
        }
        int destroyCount = destroyQueue.Count;
        for (int a = 0; a < destroyCount; a++)
        {
            var item = destroyQueue[a];
            if (item != null)
            {
                runningQueue.Remove(item);
            }
        }
        destroyQueue.Clear();
        int readyCount = actionReadyQueue.Count;
        for (int a = 0; a < destroyCount; a++)
        {
            var item = actionReadyQueue[a];
            if (item != null)
            {
                if (item.timeRemaining < 0)
                {
                    item.OnQueueCompleted.Invoke();
                }
                else
                {
                    item.OnQueueRunning.Invoke(item.timeRemaining);
                }
            }
        }
        actionReadyQueue.Clear();
    }
    public static CoroutineQueue Call(float delay)
    {
        var queue = new CoroutineQueue
        {
            timeRemaining = delay
        };
        runningQueue.Add(queue);
        return queue;
    }
}
[Serializable]
public class CoroutineQueue
{
    public Action<float> OnQueueRunning;
    public Action OnQueueCompleted;
    public float timeRemaining;
}
