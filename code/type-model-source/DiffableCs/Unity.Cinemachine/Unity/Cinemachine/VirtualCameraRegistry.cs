namespace Unity.Cinemachine;

[Token(Token = "0x20000FA")]
internal sealed class VirtualCameraRegistry
{
	[CompilerGenerated]
	[Token(Token = "0x20000FB")]
	private sealed class <>c
	{
		[Token(Token = "0x40003A4")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003A5")]
		public static Comparison<CinemachineVirtualCameraBase> <>9__8_0; //Field offset: 0x8

		[Address(RVA = "0x2865AD0", Offset = "0x2864ED0", Length = "0x67")]
		[Token(Token = "0x60004A4")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60004A5")]
		public <>c() { }

		[Address(RVA = "0x2865A40", Offset = "0x2864E40", Length = "0x8D")]
		[Token(Token = "0x60004A6")]
		internal int <GetActiveCamera>b__8_0(CinemachineVirtualCameraBase x, CinemachineVirtualCameraBase y) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003A0")]
	private readonly List<CinemachineVirtualCameraBase> m_ActiveCameras; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003A1")]
	private readonly List<List`1<CinemachineVirtualCameraBase>> m_AllCameras; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003A2")]
	private bool m_ActiveCamerasAreSorted; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40003A3")]
	private int m_ActivationSequence; //Field offset: 0x24

	[Token(Token = "0x170000FB")]
	public int ActiveCameraCount
	{
		[Address(RVA = "0x2869580", Offset = "0x2868980", Length = "0x3C")]
		[Token(Token = "0x600049C")]
		 get { } //Length: 60
	}

	[Token(Token = "0x170000FA")]
	public List<List`1<CinemachineVirtualCameraBase>> AllCamerasSortedByNestingLevel
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600049B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x28694C0", Offset = "0x28688C0", Length = "0xBD")]
	[Token(Token = "0x60004A3")]
	public VirtualCameraRegistry() { }

	[Address(RVA = "0x2868E10", Offset = "0x2868210", Length = "0xC4")]
	[Token(Token = "0x600049E")]
	public void AddActiveCamera(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x2868EE0", Offset = "0x28682E0", Length = "0x7C")]
	[Token(Token = "0x60004A0")]
	public void CameraDestroyed(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x2868F60", Offset = "0x2868360", Length = "0xAD")]
	[Token(Token = "0x60004A2")]
	public void CameraDisabled(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x2869010", Offset = "0x2868410", Length = "0x29A")]
	[Token(Token = "0x60004A1")]
	public void CameraEnabled(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x2869580", Offset = "0x2868980", Length = "0x3C")]
	[Token(Token = "0x600049C")]
	public int get_ActiveCameraCount() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600049B")]
	public List<List`1<CinemachineVirtualCameraBase>> get_AllCamerasSortedByNestingLevel() { }

	[Address(RVA = "0x28692B0", Offset = "0x28686B0", Length = "0x183")]
	[Token(Token = "0x600049D")]
	public CinemachineVirtualCameraBase GetActiveCamera(int index) { }

	[Address(RVA = "0x2869440", Offset = "0x2868840", Length = "0x7C")]
	[Token(Token = "0x600049F")]
	public void RemoveActiveCamera(CinemachineVirtualCameraBase vcam) { }

}

