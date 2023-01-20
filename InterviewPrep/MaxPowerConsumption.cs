using System;
// Problem:For a particular building you have a list of data points that describe the per-device power consumption of every device in the building.  
// Each data point looks something like this:<deviceId>,<startTime>,<endTime>,<instantaneous power consumption in Watts> 
// You can assume the following:You can have multiple records for the same device (ie a device could be turned on and off more than once in the day)

// However no two or more records for the same device can have overlapping start/end times.  
// IE a single device can be turned on more than once per day, but it can’t be turned on more than once at a time.The instantaneous power consumption (measured in watts) for a device is constant while it is on for a single data point.The instantaneous power consumption (measured in watts) for a device can vary from data point to data point.  This means that two different records for the same deviceId (with necessarily different times) might have different power consumptions. Your task then, is to calculate the maximum instantaneous power consumption across all devices in the building. 

// assuming all watts are ints
using System.Collections.Generic;

// let there be n data points
// time consumption how long to fill in priorityq n*log(n)
// time consumption for removal of priority queue n*log(n)
// what is total time? nlog(n)
// memory consumption O(n)
class Program
{
    public static void Main(string[] args)
    {
        EnergyConsumptionData data = new EnergyConsumptionData();
        data.ReadData();
        data.CalculateMaxUsage();
        Console.WriteLine($@"The max usage is {data.HistoricalMax}");
    }

    public class EnergyConsumptionData
    {
        public List<DataPoint> arrayOfValues = new List<DataPoint> { };
        // timeStamp, energy change
        public PriorityQueue<Tuple<int, int>, int> pq = new PriorityQueue<Tuple<int, int>, int> { };
        public int CurrentTotal = 0;
        public int HistoricalMax = int.MinValue;

        public void ReadData()
        {
          Console.WriteLine("Reading in values");
          arrayOfValues.Add(new DataPoint(1, 0, 2, 5));
          arrayOfValues.Add(new DataPoint(2, 1, 3, 10));
          arrayOfValues.Add(new DataPoint(2, 5, 6, 10));
          arrayOfValues.Add(new DataPoint(3, 1, 3, 20));
          arrayOfValues.Add(new DataPoint(3, 7, 8, 20));
          // the solar cell
          // arrayOfValues.Add(new DataPoint(4, 0, 8, -30));
          foreach (var datapoint in arrayOfValues)
          {
              pq.Enqueue(new (datapoint.WattsPerHour, datapoint.StartTime), datapoint.StartTime);
              pq.Enqueue(new (-datapoint.WattsPerHour, datapoint.EndTime), datapoint.EndTime);
          }
        }

        public void CalculateMaxUsage()
        {
          while (pq.Count > 0)
          {
            var timeInstance = pq.Peek().Item2;

            while (pq.Count>0 && pq.Peek().Item2== timeInstance ){
              (var currentData, var currentTime) = pq.Dequeue();
              // Console.WriteLine(currentData);
              CurrentTotal += currentData;
            }

            if (CurrentTotal > HistoricalMax)
            {
                HistoricalMax = CurrentTotal;
            }
          }
        }
    }
    public class DataPoint
    {
        public int DeviceId;
        public int StartTime;
        public int EndTime;
        public int WattsPerHour;

        public DataPoint(int deviceId, int start, int end, int watts)
        {
            this.DeviceId = deviceId;
            this.StartTime = start;
            this.EndTime = end;
            this.WattsPerHour = watts;
        }
    }
}
