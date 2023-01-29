using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Stoplight
{
    public partial class Form1 : Form
    {
        public Stopwatch stopWatch = new Stopwatch();
        public int CurrentTime;

        public Form1()
        {
            InitializeComponent();
            CurrentTime = 0;

            // Start the stopwatch
            stopWatch.Start();

            // Create a Stoplight object in order to access the Stoplight class
            Stoplight stoplight = new Stoplight();
            stoplight.Main(this);           // Perform/print the different configurations
        }

        // 
        // Method Name: timer1_Tick
        // Description: Updates the label to display the current time on the form
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Make sure the timer stops if it goes above 4 minutes
            if (stopWatch.Elapsed.Minutes >= 4)
            {
                stopWatch.Stop();
                TimeLabel.Text = "Time: --";     // Timer ends
            }
            else
            {
                // Get the elapsed time as a TimeSpan value
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                CurrentTime = ts.Seconds;
                TimeLabel.Text = "Time: " + ts.Minutes + ":" + CurrentTime.ToString("D2");     // Display the time
                stopWatch.Start();
            }
        }
    }

    // Car class
    class Car
    {
        public int sequenceNum;
        public int arrivalTime;
        public int exitTime;
        public string light;

        public Car() { }

        public int SequenceNum
        {
            get { return sequenceNum; }
            set { sequenceNum = value; }
        }

        public int ArrivalTime
        {
            get { return arrivalTime; }
            set { arrivalTime = value; }
        }

        public int ExitTime
        {
            get { return exitTime; }
            set { exitTime = value; }
        }

        public string Light
        {
            get { return light; }
            set { light = value; }
        }

        //
        // Method Name: printCarInfo
        // Description: Prints the sequence, arrival time, exit time, and wait time for the cars that pass through the intersection to the terminal
        public void printCarInfo(int waitTime)
        {
            Stoplight myObj = new Stoplight();
            string arrivalT = arrivalTime.ToString("D3");
            string exitT = exitTime.ToString("D3");
            Console.WriteLine("\n Car " + sequenceNum + " arrived at " + arrivalT[0] + ":" + arrivalT[1] + arrivalT[2] + " and left at " + exitT[0] + ":" + exitT[1] + exitT[2] + ". It waited for " + waitTime + " seconds.");
        }
    }

    // Stoplight class
    class Stoplight
    {
        // Field variables
        private string LightName;       // Name of the stoplight
        private string LightColor;      // Stoplight color

        // Constructor
        public Stoplight() { }
        
        // Constructor with two parameters
        public Stoplight(Form1 form, string lightName)
        {
            LightName = lightName;

            // Initialize the system to a starting configuration
            if (lightName == "North")       // North light will be green
            {
                form.NorthUpBtn.BackColor = Color.Gray;
                form.NorthMiddleBtn.BackColor = Color.Gray;
                form.NorthDownBtn.BackColor = Color.Green;
                LightColor = "Green";
            }
            else if (lightName == "South")      // South light will be red
            {
                form.SouthUpBtn.BackColor = Color.Red;
                form.SouthMiddleBtn.BackColor = Color.Gray;
                form.SouthDownBtn.BackColor = Color.Gray;
                LightColor = "Red";
            }
            else if (lightName == "East")       // East light will be red
            {
                form.EastUpBtn.BackColor = Color.Red;
                form.EastMiddleBtn.BackColor = Color.Gray;
                form.EastDownBtn.BackColor = Color.Gray;
                LightColor = "Red";
            }
            else if (lightName == "West")           // West light will be red
            {
                form.WestUpBtn.BackColor = Color.Red;
                form.WestMiddleBtn.BackColor = Color.Gray;
                form.WestDownBtn.BackColor = Color.Gray;
                LightColor = "Red";
            }
        }

        //
        // Method Name: ChangeLights
        // Description: Changes the lights of the specified stoplight(LightName) depending on the color given(color)
        public string ChangeLights(Form1 form, string color)
        {
            Button UpperBtn;
            Button MiddleBtn;
            Button LowerBtn;

            // Depending on which stoplight it is, stores the buttons which will have the changed color
            if (LightName == "North")
            {
                UpperBtn = form.NorthUpBtn;
                MiddleBtn = form.NorthMiddleBtn;
                LowerBtn = form.NorthDownBtn;
            }
            else if (LightName == "South")
            {
                UpperBtn = form.SouthUpBtn;
                MiddleBtn = form.SouthMiddleBtn;
                LowerBtn = form.SouthDownBtn;
            }
            else if (LightName == "East")
            {
                UpperBtn = form.EastUpBtn;
                MiddleBtn = form.EastMiddleBtn;
                LowerBtn = form.EastDownBtn;
            }
            else
            {
                UpperBtn = form.WestUpBtn;
                MiddleBtn = form.WestMiddleBtn;
                LowerBtn = form.WestDownBtn;
            }

            // Changes the colors of the stoplight
            if (color == "Red")         // Changes color to red
            {
                UpperBtn.BackColor = Color.Red;
                MiddleBtn.BackColor = Color.Gray;
                LowerBtn.BackColor = Color.Gray;
                LightColor = "Red";
            }
            else if (color == "Green")      // Changes color to green
            {
                UpperBtn.BackColor = Color.Gray;
                MiddleBtn.BackColor = Color.Gray;
                LowerBtn.BackColor = Color.Green;
                LightColor = "Green";
            }
            else if (color == "Yellow")     // Changes color to yellow
            {
                UpperBtn.BackColor = Color.Gray;
                MiddleBtn.BackColor = Color.Yellow;
                LowerBtn.BackColor = Color.Gray;
                LightColor = "Yellow";
            }
            else      // Changes color to gray
            {
                UpperBtn.BackColor = Color.Gray;
                MiddleBtn.BackColor = Color.Gray;
                LowerBtn.BackColor = Color.Gray;
                LightColor = "Gray";
            }
            return LightColor;
        }  

        //
        // Method Name: PrintConfiguration
        // Description: Prints the colors of each stoplight to the terminal
        public void PrintConfiguration()
        {
            Console.Write(String.Format("{0,12}", LightColor));
        }

        //
        // Method Name: getCarInfo
        // Description: Find the maximum size of the line of cars, find the wait times for each line, check if car passed through the interstate and notify by printing it to the terminal
        public double[] getCarInfo(List<Car> carLine, Stoplight North, Stoplight South, Stoplight East, Stoplight West, Stopwatch stopWatch2, CarObservations carObservations)
        {
            int waitTime;
            string sTime;
            int tempMax1 = 0;
            int tempMax2 = 0;
            int tempMax3 = 0;
            int tempMax4 = 0;
            int didCarPass = 0;     // Keep tracks of whether or not a car passed the interstate
            int carIndexToRemove = -1;

            // Count how many cars are in line to get through each light
            foreach(Car c in carLine)
            {
                if (c.Light == "North")
                    tempMax1++;
                else if (c.Light == "South")
                    tempMax2++;
                else if (c.Light == "East")
                    tempMax3++;
                else if (c.Light == "West")
                    tempMax4++;
            }

            // Find the maximum size of the line of cars that had to wait to get through the light
            int[] tempArray = {tempMax1, tempMax2, tempMax3, tempMax4};
            for (int i = 0; i < 4; i++)
            {
                if (tempArray[i] > carObservations.maxSizeOfLine)
                    carObservations.maxSizeOfLine = tempArray[i];
            }

            // Check if light is green and if a car is going to pass through the interstate
            foreach (Car c in carLine)
            {
                if (c.Light == "North" && North.LightColor == "Green")      // North light is green
                {
                    sTime = stopWatch2.Elapsed.Minutes.ToString() + stopWatch2.Elapsed.Seconds.ToString("D2");
                    if (int.Parse(sTime) >= c.ArrivalTime)      // If car arrived
                    {
                        c.ExitTime = int.Parse(sTime) + 1;      // Takes 1 second to pass through the interstate

                        // Get the wait time in seconds
                        int exitTimeFormat = turnIntoSeconds(c.ExitTime);
                        int arrivalTimeFormat = turnIntoSeconds(c.ArrivalTime);
                        waitTime = exitTimeFormat - arrivalTimeFormat - 1;

                        carObservations.averageSecondsWaitedNorth += waitTime;
                        c.printCarInfo(waitTime);
                        carIndexToRemove = carLine.IndexOf(c);  // Remove from line of cars
                        didCarPass = 1;
                        break;
                    }
                }
                else if (c.Light == "South" && South.LightColor == "Green")     // South light is green
                {
                    sTime = stopWatch2.Elapsed.Minutes.ToString() + stopWatch2.Elapsed.Seconds.ToString("D2");
                    if (int.Parse(sTime) >= c.ArrivalTime)      // If car arrived
                    {
                        c.ExitTime = int.Parse(sTime) + 1;      // Takes 1 second to pass through the interstate

                        // Get the wait time in seconds
                        int exitTimeFormat = turnIntoSeconds(c.ExitTime);
                        int arrivalTimeFormat = turnIntoSeconds(c.ArrivalTime);
                        waitTime = exitTimeFormat - arrivalTimeFormat - 1;

                        carObservations.averageSecondsWaitedSouth += waitTime;
                        c.printCarInfo(waitTime);       // Notify that the car passed through the interstate
                        carIndexToRemove = carLine.IndexOf(c);  // Remove from line of cars            
                        didCarPass = 1;
                        break;
                    }
                }
                else if (c.Light == "East" && East.LightColor == "Green")       // East light is green
                {
                    sTime = stopWatch2.Elapsed.Minutes.ToString() + stopWatch2.Elapsed.Seconds.ToString("D2");
                    if (int.Parse(sTime) >= c.ArrivalTime)      // If car arrived
                    {
                        c.ExitTime = int.Parse(sTime) + 1;      // Takes 1 second to pass through the interstate

                        // Get the wait time in seconds
                        int exitTimeFormat = turnIntoSeconds(c.ExitTime);
                        int arrivalTimeFormat = turnIntoSeconds(c.ArrivalTime);
                        waitTime = exitTimeFormat - arrivalTimeFormat - 1;

                        carObservations.averageSecondsWaitedEast += waitTime;
                        c.printCarInfo(waitTime);       // Notify that the car passed through the interstate
                        carIndexToRemove = carLine.IndexOf(c);  // Remove from line of cars
                        didCarPass = 1;
                        break;
                    }
                }
                else if (c.Light == "West" && West.LightColor == "Green")       // West light is green
                {
                    sTime = stopWatch2.Elapsed.Minutes.ToString() + stopWatch2.Elapsed.Seconds.ToString("D2");
                    if (int.Parse(sTime) >= c.ArrivalTime)      // If car arrived
                    {
                        c.ExitTime = int.Parse(sTime) + 1;      // Takes 1 second to pass through the interstate

                        // Get the wait time in seconds
                        int exitTimeFormat = turnIntoSeconds(c.ExitTime);
                        int arrivalTimeFormat = turnIntoSeconds(c.ArrivalTime);
                        waitTime = exitTimeFormat - arrivalTimeFormat - 1;

                        carObservations.averageSecondsWaitedWest += waitTime;
                        c.printCarInfo(waitTime);       // Notify that the car passed through the interstate
                        carIndexToRemove = carLine.IndexOf(c);  // Remove from line of cars
                        didCarPass = 1;
                        break;
                    }
                }
            }

            // Return the maximum size of the line, the average seconds waited for each light, and whether or not a car passed through the intertate
            double[] returnInfo = new double[7];
            returnInfo[0] = carObservations.maxSizeOfLine;
            returnInfo[1] = carObservations.averageSecondsWaitedNorth;
            returnInfo[2] = carObservations.averageSecondsWaitedSouth;
            returnInfo[3] = carObservations.averageSecondsWaitedEast;
            returnInfo[4] = carObservations.averageSecondsWaitedWest;
            returnInfo[5] = didCarPass;
            returnInfo[6] = carIndexToRemove;
            return returnInfo;
        }

        // 
        // Method Name: turnIntoSeconds
        // Description: Turn the time from the format 1:16 to 76 seconds (for example)
        public int turnIntoSeconds(int inputTime)
        {
            string time = inputTime.ToString("D3");
            int minutes = int.Parse(time[0].ToString()) * 60;
            string secs = time[1].ToString() + time[2].ToString();
            int seconds = minutes + int.Parse(secs);
            return seconds;
        }

        // Struct to keep track of car observations information
        public struct CarObservations
        {
            // Number of cars in each light
            public int northNumCars;
            public int southNumCars;
            public int eastNumCars;
            public int westNumCars;

            // Maximum size of the line of cars that had to wait to get rhough the light
            public int maxSizeOfLine;

            // Average amount of times that cars wait based on which direction they are coming from
            public double averageSecondsWaitedNorth;
            public double averageSecondsWaitedSouth;
            public double averageSecondsWaitedEast;
            public double averageSecondsWaitedWest;
        }

        // 
        // Method Name: Main
        // Description: Performs and prints the different configurations
        public async void Main(Form1 form)
        {
            // Call struct
            CarObservations carObservations = new CarObservations();

            // Create four objects for each stoplight
            Stoplight North = new Stoplight(form, "North");
            Stoplight South = new Stoplight(form, "South");
            Stoplight East = new Stoplight(form, "East");
            Stoplight West = new Stoplight(form, "West");

            // Print the table columns on the console
            Console.WriteLine(" {0,12} {1,12} {2,12} {3,12} {4,12} ", "Current Time", "North Light", "South Light", "East Light", "West Light");
            Console.WriteLine(" {0,12} {1,12} {2,12} {3,12} {4,12} ", "------------", "-----------", "-----------", "----------", "----------");

            // Stopwatch
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();

            // Open the file and store car info
            StreamReader inputFile = File.OpenText("CarObservationsFile.txt");
            List<Car> carLine = new List<Car>();
            string inputLine = null;
            int index = 0;
            while(!inputFile.EndOfStream)
            {
                inputLine = inputFile.ReadLine();
                string[] inputInfo = inputLine.Split(',');
                Car incomingCar = new Car();
                carLine.Add(incomingCar);
                carLine[index].Light = inputInfo[0];
                carLine[index].SequenceNum = index;
                carLine[index].ArrivalTime = Int32.Parse(inputInfo[1]);

                // Count number of cars in each line
                if (carLine[index].Light == "North")
                    carObservations.northNumCars++;
                else if (carLine[index].Light == "South")
                    carObservations.southNumCars++;
                else if (carLine[index].Light == "East")
                    carObservations.eastNumCars++;
                else if (carLine[index].Light == "West")
                    carObservations.westNumCars++;

                index++;
            }

            // Print the information about the first configuration
            Console.Write("{0,12}", stopWatch2.Elapsed.Minutes + ":" + stopWatch2.Elapsed.Seconds.ToString("D2"));
            North.PrintConfiguration();
            South.PrintConfiguration();
            East.PrintConfiguration();
            West.PrintConfiguration();

            // Keep track of the colors for each stoplight
            string northLight = "Green";
            string southLight = "Gray";
            string eastLight = "Gray";
            string westLight = "Gray";

            Boolean didSouthChange = false;
            Boolean didEastChange = false;
            Boolean didWestChange = false;

            // Store infromation about cars
            double[] returnedInfo;

            // The system will run for 240 seconds and then terminate the program
            while (stopWatch2.Elapsed.Minutes <= 4) 
            {
                // Check whether car is going to pass through the interstate, collect information
                returnedInfo = getCarInfo(carLine, North, South, East, West, stopWatch2, carObservations);
                if (returnedInfo[5] == 1)       // If light is green, take one second for car to pass through the intersection
                    carLine.Remove(carLine[(int) returnedInfo[6]]);     // Remove from car line
                carObservations.maxSizeOfLine = (int) returnedInfo[0];
                carObservations.averageSecondsWaitedNorth = returnedInfo[1];
                carObservations.averageSecondsWaitedSouth = returnedInfo[2];
                carObservations.averageSecondsWaitedEast = returnedInfo[3];
                carObservations.averageSecondsWaitedWest = returnedInfo[4];

                // South light goes green AFTER North has been green for 6 seconds
                if (northLight == "Green")
                {
                    await Task.Delay(6000);
                    if (stopWatch2.Elapsed.Minutes > 4)        // Terminate program if at or over 240 seconds
                        break;
                    southLight = South.ChangeLights(form, "Green");         // Change South light to green
                    // Print configurations
                    Console.Write("\n{0,12}", stopWatch2.Elapsed.Minutes + ":" + stopWatch2.Elapsed.Seconds.ToString("D2"));
                    North.PrintConfiguration();
                    South.PrintConfiguration();
                    East.PrintConfiguration();
                    West.PrintConfiguration();

                    didSouthChange = true;

                    // Check whether car is going to pass through the interstate, collect information
                    returnedInfo = getCarInfo(carLine, North, South, East, West, stopWatch2, carObservations);
                    if (returnedInfo[5] == 1)       // If light is green, take one second for car to pass through the intersection
                        carLine.Remove(carLine[(int)returnedInfo[6]]);     // Remove from car line
                    carObservations.maxSizeOfLine = (int)returnedInfo[0];
                    carObservations.averageSecondsWaitedNorth = returnedInfo[1];
                    carObservations.averageSecondsWaitedSouth = returnedInfo[2];
                    carObservations.averageSecondsWaitedEast = returnedInfo[3];
                    carObservations.averageSecondsWaitedWest = returnedInfo[4];

                    await Task.Delay(3000);
                    if (stopWatch2.Elapsed.Minutes >= 4)        // Terminate program if at or over 240 seconds
                        break;
                    northLight = North.ChangeLights(form, "Yellow");        // Change North light to yellow
                    // Print configurations
                    Console.Write("\n{0,12}", stopWatch2.Elapsed.Minutes + ":" + stopWatch2.Elapsed.Seconds.ToString("D2"));
                    North.PrintConfiguration();
                    South.PrintConfiguration();
                    East.PrintConfiguration();
                    West.PrintConfiguration();

                    await Task.Delay(3000);
                    if (stopWatch2.Elapsed.Minutes >= 4)
                        break;
                    northLight = North.ChangeLights(form, "Red");           // Change North light to red

                    if (stopWatch2.Elapsed.Minutes >= 4)
                        break;
                    southLight = South.ChangeLights(form, "Yellow");        // Change South light to yellow
                    // Print configurations
                    Console.Write("\n{0,12}", stopWatch2.Elapsed.Minutes + ":" + stopWatch2.Elapsed.Seconds.ToString("D2"));
                    North.PrintConfiguration();
                    South.PrintConfiguration();
                    East.PrintConfiguration();
                    West.PrintConfiguration();

                    await Task.Delay(3000);
                    if (stopWatch2.Elapsed.Minutes >= 4)
                        break;
                    southLight = South.ChangeLights(form, "Red");           // Change South light to red
                }

                // East light goes green WHEN South light turns red
                // Repeat sequence for East and West lights
                else if (southLight == "Red")
                {
                    eastLight = East.ChangeLights(form, "Green");           // Change East light to Green
                    // Print configurations
                    Console.Write("\n{0,12}", stopWatch2.Elapsed.Minutes + ":" + stopWatch2.Elapsed.Seconds.ToString("D2"));
                    North.PrintConfiguration();
                    South.PrintConfiguration();
                    East.PrintConfiguration();
                    West.PrintConfiguration();

                    didEastChange = true;

                    // Check whether car is going to pass through the interstate, collect information
                    returnedInfo = getCarInfo(carLine, North, South, East, West, stopWatch2, carObservations);
                    if (returnedInfo[5] == 1)       // If light is green, take one second for car to pass through the intersection
                        carLine.Remove(carLine[(int)returnedInfo[6]]);     // Remove from car line
                    carObservations.maxSizeOfLine = (int)returnedInfo[0];
                    carObservations.averageSecondsWaitedNorth = returnedInfo[1];
                    carObservations.averageSecondsWaitedSouth = returnedInfo[2];
                    carObservations.averageSecondsWaitedEast = returnedInfo[3];
                    carObservations.averageSecondsWaitedWest = returnedInfo[4];

                    // Wait before turning West stoplight green
                    await Task.Delay(6000);

                    if (westLight != "Green")
                    {
                        if (stopWatch2.Elapsed.Minutes >= 4)
                            break;
                        westLight = West.ChangeLights(form, "Green");       // Change West light to green
                        // Print configurations
                        Console.Write("\n{0,12}", stopWatch2.Elapsed.Minutes + ":" + stopWatch2.Elapsed.Seconds.ToString("D2"));
                        North.PrintConfiguration();
                        South.PrintConfiguration();
                        East.PrintConfiguration();
                        West.PrintConfiguration();

                        didWestChange = true;

                        // Check whether car is going to pass through the interstate, collect information
                        returnedInfo = getCarInfo(carLine, North, South, East, West, stopWatch2, carObservations);
                        if (returnedInfo[5] == 1)       // If light is green, take one second for car to pass through the intersection
                            carLine.Remove(carLine[(int)returnedInfo[6]]);     // Remove from car line
                        carObservations.maxSizeOfLine = (int)returnedInfo[0];
                        carObservations.averageSecondsWaitedNorth = returnedInfo[1];
                        carObservations.averageSecondsWaitedSouth = returnedInfo[2];
                        carObservations.averageSecondsWaitedEast = returnedInfo[3];
                        carObservations.averageSecondsWaitedWest = returnedInfo[4];

                        await Task.Delay(3000);
                    }

                    if (stopWatch2.Elapsed.Minutes >= 4)
                        break;
                    eastLight = East.ChangeLights(form, "Yellow");       // Change East light to yellow
                    // Print configurations
                    Console.Write("\n{0,12}", stopWatch2.Elapsed.Minutes + ":" + stopWatch2.Elapsed.Seconds.ToString("D2"));
                    North.PrintConfiguration();
                    South.PrintConfiguration();
                    East.PrintConfiguration();
                    West.PrintConfiguration();

                    await Task.Delay(3000);

                    if (stopWatch2.Elapsed.Minutes >= 4)
                        break;
                    eastLight = East.ChangeLights(form, "Red");          // Change East light to red

                    if (stopWatch2.Elapsed.Minutes >= 4)
                        break;
                    westLight = West.ChangeLights(form, "Yellow");           // Change West light to yellow
                    // Print configurations
                    Console.Write("\n{0,12}", stopWatch2.Elapsed.Minutes + ":" + stopWatch2.Elapsed.Seconds.ToString("D2"));
                    North.PrintConfiguration();
                    South.PrintConfiguration();
                    East.PrintConfiguration();
                    West.PrintConfiguration();

                    await Task.Delay(3000);
                    if (stopWatch2.Elapsed.Minutes >= 4)
                        break;
                    westLight = West.ChangeLights(form, "Red");             // Change West light to red
                }

                // North light goes green AFTER West light goes red
                if (westLight == "Red")
                {
                    if (didSouthChange == true && didEastChange == true && didWestChange == true)
                    { 
                        northLight = North.ChangeLights(form, "Green");         // Change North light to green
                        // Print configurations
                        Console.Write("\n{0,12}", stopWatch2.Elapsed.Minutes + ":" + stopWatch2.Elapsed.Seconds.ToString("D2"));
                        North.PrintConfiguration();
                        South.PrintConfiguration();
                        East.PrintConfiguration();
                        West.PrintConfiguration();

                        // Check whether car is going to pass through the interstate, collect information
                        returnedInfo = getCarInfo(carLine, North, South, East, West, stopWatch2, carObservations);
                        if (returnedInfo[5] == 1)       // If light is green, take one second for car to pass through the intersection
                            carLine.Remove(carLine[(int)returnedInfo[6]]);     // Remove from car line
                        carObservations.maxSizeOfLine = (int)returnedInfo[0];
                        carObservations.averageSecondsWaitedNorth = returnedInfo[1];
                        carObservations.averageSecondsWaitedSouth = returnedInfo[2];
                        carObservations.averageSecondsWaitedEast = returnedInfo[3];
                        carObservations.averageSecondsWaitedWest = returnedInfo[4];
                        didSouthChange = false;
                        didEastChange = false;
                        didWestChange = false;
                    }
                }
            }
            // Stop the timers
            form.stopWatch.Stop();
            stopWatch2.Stop();

            // Simulation is complete, print observations
            Console.WriteLine("\n\nThe number of cars coming from the North direction: " + carObservations.northNumCars);
            Console.WriteLine("The number of cars coming from the South direction: " + carObservations.southNumCars);
            Console.WriteLine("The number of cars coming from the East direction: " + carObservations.eastNumCars);
            Console.WriteLine("The number of cars coming from the West direction: " + carObservations.westNumCars);

            Console.WriteLine("The maximum size of the line of cars that had to wait to get through the light: " + carObservations.maxSizeOfLine);

            // Calculate averages of each light
            carObservations.averageSecondsWaitedNorth /= carObservations.northNumCars;
            carObservations.averageSecondsWaitedSouth /= carObservations.southNumCars;
            carObservations.averageSecondsWaitedEast /= carObservations.eastNumCars;
            carObservations.averageSecondsWaitedWest /= carObservations.westNumCars;

            Console.WriteLine("The average amount of time that cars from the North direction waited for: " + carObservations.averageSecondsWaitedNorth.ToString("0.00") + " seconds");
            Console.WriteLine("The average amount of time that cars from the South direction waited for: " + carObservations.averageSecondsWaitedSouth.ToString("0.00") + " seconds");
            Console.WriteLine("The average amount of time that cars from the East direction waited for: " + carObservations.averageSecondsWaitedEast.ToString("0.00") + " seconds");
            Console.WriteLine("The average amount of time that cars from the West direction waited for: " + carObservations.averageSecondsWaitedWest.ToString("0.00") + " seconds");
            
            // Close file
            inputFile.Close();
        }
    }
}
