	double Sinusoid(double value)
	{
		return Mathf.Sin((float) value);
	}

	double ArcTan(double value)
	{
		return Mathf.Atan((float) value);
	}

	double SoftSign(double value)
	{
		return value/(1+Mathf.Abs((float)value));
	}