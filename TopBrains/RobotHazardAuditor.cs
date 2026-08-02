using System;
using System.Reflection;
using System.Reflection.PortableExecutable;
namespace TopBrains
{
    public class RobotHazardAuditor
    {
        static void RobotHazardAuditorMain()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Enter armPrecision");
            double armprecision=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter WorkDensity");
            int workDensity=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter MachineState");
            string? machineState=Console.ReadLine();
            Console.WriteLine(CalculateHazardRisk(armprecision,workDensity,machineState));
            
        }
        public static double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
        {
           
            if (armPrecision > 1|| armPrecision<0)
            {
                throw new RobotException("Error:  Arm precision must be 0.0-1.0");
            }
            if(workerDensity>20 || workerDensity < 1)
            {
                throw new RobotException("Error: Worker density must be 1-20");
            }
            if(!(machineryState=="Worn" || machineryState=="Faulty" || machineryState == "Critical"))
            {
                throw new RobotException("Error: Unsupported machinery state");
            }
            double machineRiskFactor=0;
            if (machineryState == "Worn")
            {
                machineRiskFactor=1.3;
            }else if (machineryState == "Faulty")
            {
                machineRiskFactor=2.0;

            }
            else
            {
                machineRiskFactor=3.0;
            }

            
            return  ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);
            
        }
        
    }

    public class RobotException: Exception
    {
        public RobotException(string messge) : base(messge)
        {
            
        }
        
    }
}