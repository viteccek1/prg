namespace ProtectedNamespaces
{
    public class CombatRobot : ProtectedNamespaces.Robots.BaseRobot
    {
        public CombatRobot(string modelName, int batteryCapacity) : base(modelName, batteryCapacity)
        {
        }

        public void ShowStatus()
        {
            Console.WriteLine($"ModelName: {ModelName}");
            Console.WriteLine($"BaterryLevel: {BatteryLevel}");
        }
    }
}
