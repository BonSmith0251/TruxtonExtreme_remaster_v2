namespace InGame.Kernel;

[Token(Token = "0x2000004")]
public class CinemachineMan : MonoBehaviourSingleton<CinemachineMan>
{
	[Token(Token = "0x4000006")]
	public static readonly float DefaultCameraAngle; //Field offset: 0x0
	[Token(Token = "0x4000007")]
	public static readonly float DefaultCameraSlide; //Field offset: 0x4
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000008")]
	private CinemachineCamera[] _cameras; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000009")]
	private CinemachineBasicMultiChannelPerlin[] _camerasNoise; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000A")]
	private float _cameraNoisePow; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400000B")]
	private float _sec1st; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000C")]
	private float _sec2nd; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400000D")]
	private float _sec2ndMax; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400000E")]
	private float _npow; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400000F")]
	private CinemachineCamera _current; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000010")]
	private float _perspectiveAngle; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000011")]
	private float _bgCameraRate; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000012")]
	private Transform _BGRootTransform; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000013")]
	private Vector3 _BGCameraSlideRange; //Field offset: 0x60
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000014")]
	private Vector3 _shakeOffset; //Field offset: 0x6C
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000015")]
	private Quaternion _cameraRotate; //Field offset: 0x78
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000016")]
	private Quaternion _shakeRotate; //Field offset: 0x88
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000017")]
	private int _cameraCount; //Field offset: 0x98

	[Token(Token = "0x17000004")]
	public Vector3 BGCameraPos
	{
		[Address(RVA = "0x1CC69E0", Offset = "0x1CC5DE0", Length = "0x55")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000003")]
	public Vector3 BGCameraSlide
	{
		[Address(RVA = "0x1CC6A40", Offset = "0x1CC5E40", Length = "0x13")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000001")]
	public CinemachineCamera Current
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000002")]
	public float PerspectiveAngle
	{
		[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
		[Token(Token = "0x6000013")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1CC68B0", Offset = "0x1CC5CB0", Length = "0x12A")]
	[Token(Token = "0x6000011")]
	private void _updateCameras(Vector3 lpos, Quaternion lrot) { }

	[Address(RVA = "0x1CC6750", Offset = "0x1CC5B50", Length = "0x4E")]
	[Token(Token = "0x6000017")]
	private static CinemachineMan() { }

	[Address(RVA = "0x1CC67A0", Offset = "0x1CC5BA0", Length = "0x110")]
	[Token(Token = "0x6000016")]
	public CinemachineMan() { }

	[Address(RVA = "0x1CC53E0", Offset = "0x1CC47E0", Length = "0x213")]
	[Token(Token = "0x6000003")]
	protected virtual void Awake() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000007")]
	public void DebugCameraUpdate(Transform p = null) { }

	[Address(RVA = "0x1CC5600", Offset = "0x1CC4A00", Length = "0x1B0")]
	[Token(Token = "0x600000B")]
	private void FixedUpdate() { }

	[Address(RVA = "0x1CC69E0", Offset = "0x1CC5DE0", Length = "0x55")]
	[Token(Token = "0x6000015")]
	public Vector3 get_BGCameraPos() { }

	[Address(RVA = "0x1CC6A40", Offset = "0x1CC5E40", Length = "0x13")]
	[Token(Token = "0x6000014")]
	public Vector3 get_BGCameraSlide() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000012")]
	public CinemachineCamera get_Current() { }

	[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
	[Token(Token = "0x6000013")]
	public float get_PerspectiveAngle() { }

	[Address(RVA = "0x1CC57C0", Offset = "0x1CC4BC0", Length = "0xB2")]
	[Token(Token = "0x6000010")]
	private int GetCameraIndex(string tname) { }

	[Address(RVA = "0x1CC5880", Offset = "0x1CC4C80", Length = "0x4BA")]
	[Token(Token = "0x600000F")]
	public void SetBGCameraRoll(float rx) { }

	[Address(RVA = "0x1CC5D50", Offset = "0x1CC5150", Length = "0x2ED")]
	[Token(Token = "0x600000E")]
	public void SetBGCameraSlide(float r) { }

	[Address(RVA = "0x1CC5D40", Offset = "0x1CC5140", Length = "0x6")]
	[Token(Token = "0x600000D")]
	public void SetBGCameraSlideRange(float w) { }

	[Address(RVA = "0x1CC6040", Offset = "0x1CC5440", Length = "0xC6")]
	[Token(Token = "0x600000C")]
	public void SetBGCameraTransform(Transform bgct, float w) { }

	[Address(RVA = "0x1CC6110", Offset = "0x1CC5510", Length = "0x213")]
	[Token(Token = "0x6000008")]
	public void SetCameraNoise(float n) { }

	[Address(RVA = "0x1CC6330", Offset = "0x1CC5730", Length = "0x15")]
	[Token(Token = "0x6000009")]
	public void ShakeCamera(float npow, float nsec1st, float nsec2nd) { }

	[Address(RVA = "0x1CC6350", Offset = "0x1CC5750", Length = "0x15")]
	[Token(Token = "0x600000A")]
	public void ShakeStop() { }

	[Address(RVA = "0x1CC6370", Offset = "0x1CC5770", Length = "0x10D")]
	[Token(Token = "0x6000005")]
	public CinemachineCamera StartCamera(int cindex) { }

	[Address(RVA = "0x1CC6480", Offset = "0x1CC5880", Length = "0x1A0")]
	[Token(Token = "0x6000004")]
	public CinemachineCamera StartCamera(string cname) { }

	[Address(RVA = "0x1CC6630", Offset = "0x1CC5A30", Length = "0x11B")]
	[Token(Token = "0x6000006")]
	public void StopBGCamera() { }

}

