namespace LoggingKata
{
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            var cells = line.Split(',');

            

            if (cells.Length < 3)
            {
                logger.LogError("Need More Info");
                return null;
            }

            


            double latitude = double.Parse(cells[0]);
            double longitude = double.Parse(cells[1]);
            string name = cells[2];

            TacoBell TB = new TacoBell();
            TB.Name = name;


            Point Location = new Point();

            Location.Latitude = latitude;
            Location.Longitude = longitude;

            TB.Location = Location;
            
            

            return TB;


            
        }

      
         





    }
}