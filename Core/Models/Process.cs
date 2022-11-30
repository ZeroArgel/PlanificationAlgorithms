namespace Core.Models
{
    public class Process
    {
        public Process(int order, string id, double value)
        {
            Order = order;
            Id = id;
            Value = value;
        }

        public Process(string id, double value, int priority)
        {
            Id = id;
            Value = value;
            Priority = priority;
        }

        public Process(int order, string id, double value, int cpuBurnTime)
        {
            CpuBurnTime = cpuBurnTime;
            Id = id;
            Value = value;
            Order = order;
        }

        internal int Order { get; }
        public string Id { get; }
        internal double Value { get; }
        internal int CpuBurnTime { get; }
        internal int Priority { get; }
        public double ReturnValue { get; private set; }

        internal void SetReturnValue(double returnValue) => ReturnValue = returnValue;
    }
}