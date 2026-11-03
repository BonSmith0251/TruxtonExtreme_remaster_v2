namespace Unity.Cinemachine;

[Token(Token = "0x20000E4")]
public struct SplineAutoDolly
{
	[Token(Token = "0x20000E6")]
	internal class FixedSpeed : ISplineAutoDolly
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400036B")]
		[Tooltip("Speed of travel, in current position units per second.")]
		public float Speed; //Field offset: 0x10

		[Token(Token = "0x170000E9")]
		private override bool Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.RequiresTrackingTarget
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000435")]
			private get { } //Length: 3
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000437")]
		public FixedSpeed() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000435")]
		private override bool Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.get_RequiresTrackingTarget() { }

		[Address(RVA = "0x28449E0", Offset = "0x2843DE0", Length = "0xF8")]
		[Token(Token = "0x6000436")]
		private override float Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.GetSplinePosition(MonoBehaviour sender, Transform target, SplineContainer spline, float currentPosition, PathIndexUnit positionUnits, float deltaTime) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000434")]
		private override void Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000433")]
		private override void Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.Validate() { }

	}

	[Token(Token = "0x20000E5")]
	internal interface ISplineAutoDolly
	{

		[Token(Token = "0x170000E8")]
		public bool RequiresTrackingTarget
		{
			[Token(Token = "0x6000431")]
			 get { } //Length: 0
		}

		[Token(Token = "0x6000431")]
		public bool get_RequiresTrackingTarget() { }

		[Token(Token = "0x6000432")]
		public float GetSplinePosition(MonoBehaviour sender, Transform target, SplineContainer spline, float currentPosition, PathIndexUnit positionUnits, float deltaTime) { }

		[Token(Token = "0x6000430")]
		public void Reset() { }

		[Token(Token = "0x600042F")]
		public void Validate() { }

	}

	[Token(Token = "0x20000E7")]
	internal class NearestPointToTarget : ISplineAutoDolly
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400036C")]
		[Tooltip("Offset, in current position units, from the closest point on the spline to the follow target")]
		public float PositionOffset; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400036D")]
		[Tooltip("Affects how many segments to split a spline into when calculating the nearest point.  Higher values mean smaller and more segments, which increases accuracy at the cost of processing time.  In most cases, the default value (4) is appropriate. Use with SearchIteration to fine-tune point accuracy.")]
		public int SearchResolution; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400036E")]
		[Tooltip("The nearest point is calculated by finding the nearest point on the entire length of the spline using SearchResolution to divide into equally spaced line segments. Successive iterations will then subdivide further the nearest segment, producing more accurate results. In most cases, the default value (2) is sufficient.")]
		public int SearchIteration; //Field offset: 0x18

		[Token(Token = "0x170000EA")]
		private override bool Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.RequiresTrackingTarget
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x600043A")]
			private get { } //Length: 3
		}

		[Address(RVA = "0x2846D30", Offset = "0x2846130", Length = "0x15")]
		[Token(Token = "0x600043C")]
		public NearestPointToTarget() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600043A")]
		private override bool Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.get_RequiresTrackingTarget() { }

		[Address(RVA = "0x2846A80", Offset = "0x2845E80", Length = "0x27C")]
		[Token(Token = "0x600043B")]
		private override float Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.GetSplinePosition(MonoBehaviour sender, Transform target, SplineContainer spline, float currentPosition, PathIndexUnit positionUnits, float deltaTime) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000439")]
		private override void Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.Reset() { }

		[Address(RVA = "0x2846D00", Offset = "0x2846100", Length = "0x21")]
		[Token(Token = "0x6000438")]
		private override void Unity.Cinemachine.SplineAutoDolly.ISplineAutoDolly.Validate() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000369")]
	[Tooltip("If set, will enable the selected automatic dolly along the spline")]
	public bool Enabled; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeReference]
	[Token(Token = "0x400036A")]
	public ISplineAutoDolly Method; //Field offset: 0x8

}

