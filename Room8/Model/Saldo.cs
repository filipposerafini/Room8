using System;
namespace Room8
{
	public class Saldo : MovimentoDiDenaro
	{
		private DateTime _data;

        public Saldo()
		{
		}

		public DateTime Data
		{
			get { return _data; }
            set
            {
                if (value.Equals(DateTime.MinValue))
                    throw new ArgumentNullException("data");
                if (value.CompareTo(DateTime.Now) > 0)
                    throw new ArgumentException("La data non può essere successiva a quella di oggi", "data");
                _data = value;
            }
		}
	}
}
