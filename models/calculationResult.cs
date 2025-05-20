namespace mini_project.Models
{
	public class CalculationResult
	{
		public double FirstNumber { get; set; }
		public double SecondNumber { get; set; }
		public required string Operation { get; set; }
		public double Result { get; set; }
		public DateTime CalculationTime { get; set; }

		public CalculationResult()
		{
			CalculationTime = DateTime.Now;
		}

		 public override string ToString()
        {
            return $"{FirstNumber} {Operation} {SecondNumber} = {Result} (calculated at {CalculationTime.ToShortTimeString()})";
        }
	}
	} 