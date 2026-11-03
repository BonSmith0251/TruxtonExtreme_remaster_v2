namespace UnityEngine.UIElements;

[Token(Token = "0x2000280")]
internal class CameraScreenRaycaster : IScreenRaycaster
{
	[CompilerGenerated]
	[Token(Token = "0x2000282")]
	private sealed class <>c
	{
		[Token(Token = "0x40009F2")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40009F3")]
		public static Comparison<Camera> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x33F4610", Offset = "0x33F3A10", Length = "0x67")]
		[Token(Token = "0x6001195")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001196")]
		public <>c() { }

		[Address(RVA = "0x33F4380", Offset = "0x33F3780", Length = "0x55")]
		[Token(Token = "0x6001197")]
		internal int <Update>b__3_0(Camera a, Camera b) { }

	}

	[Token(Token = "0x2000281")]
	internal class CameraRayEnumerator : IEnumerator<ValueTuple`3<Ray, Camera, Boolean>>, IEnumerator, IDisposable, IEnumerable<ValueTuple`3<Ray, Camera, Boolean>>, IEnumerable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009EA")]
		private Camera[] m_Cameras; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009EB")]
		private int m_LayerMask; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40009EC")]
		private Vector2 m_MousePosition; //Field offset: 0x1C
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40009ED")]
		private Nullable<Int32> m_TargetDisplay; //Field offset: 0x24
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40009EE")]
		private int m_Index; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40009EF")]
		private Camera m_CurrentCamera; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40009F0")]
		private Ray m_CurrentRay; //Field offset: 0x38
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40009F1")]
		private bool m_IsInsideCameraRect; //Field offset: 0x50

		[Token(Token = "0x17000360")]
		public override ValueTuple<Ray, Camera, Boolean> Current
		{
			[Address(RVA = "0x33E14A0", Offset = "0x33E08A0", Length = "0x80")]
			[Token(Token = "0x600118E")]
			 get { } //Length: 128
		}

		[Token(Token = "0x17000361")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x33E13C0", Offset = "0x33E07C0", Length = "0xD0")]
			[Token(Token = "0x600118F")]
			private get { } //Length: 208
		}

		[Address(RVA = "0x33E1490", Offset = "0x33E0890", Length = "0xE")]
		[Token(Token = "0x6001194")]
		public CameraRayEnumerator() { }

		[Address(RVA = "0x33E1100", Offset = "0x33E0500", Length = "0x74")]
		[Token(Token = "0x6001193")]
		public override void Dispose() { }

		[Address(RVA = "0x33E14A0", Offset = "0x33E08A0", Length = "0x80")]
		[Token(Token = "0x600118E")]
		public override ValueTuple<Ray, Camera, Boolean> get_Current() { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6001190")]
		public override IEnumerator<ValueTuple`3<Ray, Camera, Boolean>> GetEnumerator() { }

		[Address(RVA = "0x33E1180", Offset = "0x33E0580", Length = "0xBC")]
		[Token(Token = "0x6001192")]
		public static CameraRayEnumerator GetPooled(Camera[] cameras, int layerMask, Vector2 mousePosition, Nullable<Int32> targetDisplay) { }

		[Address(RVA = "0x33E1240", Offset = "0x33E0640", Length = "0x16E")]
		[Token(Token = "0x600118C")]
		public override bool MoveNext() { }

		[Address(RVA = "0x33E13B0", Offset = "0x33E07B0", Length = "0x8")]
		[Token(Token = "0x600118D")]
		public override void Reset() { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6001191")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x33E13C0", Offset = "0x33E07C0", Length = "0xD0")]
		[Token(Token = "0x600118F")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009E7")]
	public Camera[] cameras; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009E8")]
	public Camera[] singleCamera; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009E9")]
	public int layerMask; //Field offset: 0x20

	[Address(RVA = "0x33E1A60", Offset = "0x33E0E60", Length = "0x84")]
	[Token(Token = "0x600118B")]
	public CameraScreenRaycaster() { }

	[Address(RVA = "0x33E1520", Offset = "0x33E0920", Length = "0xEA")]
	[Token(Token = "0x6001189")]
	private static bool IsValid(Camera camera, int layerMask, Nullable<Int32> targetDisplay) { }

	[Address(RVA = "0x33E1610", Offset = "0x33E0A10", Length = "0x160")]
	[Token(Token = "0x6001188")]
	public override IEnumerable<ValueTuple`3<Ray, Camera, Boolean>> MakeRay(Vector2 mousePosition, int pointerId, Nullable<Int32> targetDisplay) { }

	[Address(RVA = "0x33E1780", Offset = "0x33E0B80", Length = "0x1B8")]
	[Token(Token = "0x600118A")]
	private static bool MakeRay(Camera camera, Vector2 mousePosition, out Ray ray) { }

	[Address(RVA = "0x33E1940", Offset = "0x33E0D40", Length = "0x111")]
	[Token(Token = "0x6001187")]
	public override void Update() { }

}

