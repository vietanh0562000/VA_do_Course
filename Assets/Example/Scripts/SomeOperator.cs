namespace Example.Scripts
{
	using System;
	using UnityEngine;

	public class SomeOperator
	{
		// ?
		public void Main()
		{
			int? a = null;
			int? b = 5;
			int? c = null;

			// Using the null coalescing operator to provide a default value
			int result1 = a ?? 0; // result1 is 0
			int result2 = b ?? 0; // result2 is 5
			int result3 = c ?? 0; // result3 is 0
			
			// The null coalescing operator ?? is used to provide a default value when a nullable value is null.
			// If the left-hand side of the operator is not null, it is returned.
			// Otherwise, the right-hand side of the operator is returned.
			// So, in the expression a??b??c, if a is not null, it is returned.
			// Otherwise, if b is not null, it is returned.
			// If both a and b are null, c is returned.
		}

		private ExProperties _exProperties;

		public void Validate()
		{
			_exProperties ??= new ExProperties();
		}
	}

	public class LambdaDemo
	{
		private         string fname = "Thang";
		private         string lname = "Nguyen";
		
		public override string ToString() => $"{fname} {lname}".Trim();

		public Vector3       one;
		public Vector3 two;

		private Func<Vector3, Vector3> plus = x => x + x;

		public void Main()
		{
			one = Vector3.one;
		}
	}
}