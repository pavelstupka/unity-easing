namespace UnityEasing  {
	
	/// <summary>
	/// Float easing.
	/// </summary>
	public class FloatEasing : Easing<float>
	{
		public FloatEasing(float from, float to, float duration, EasingType easingType) : base(from, to, duration, easingType) { }

		protected override float ComputeChange(float from, float to)
		{
			return to - from;
		}

		protected override float ComputeValue(float value, float time, float begin, float change, float duration, EasingFunction easingFunction)
		{
			return easingFunction(time, begin, change, duration);
		}
	}
}
