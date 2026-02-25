namespace ProtectedNamespaces.Robots;

    public class BaseRobot
    {
        public string ModelName;
        protected int BatteryLevel;

        public BaseRobot(string modelName, int batteryCapacity)
        {
            ModelName = modelName;
            BatteryLevel = batteryCapacity;
        }
    } 


