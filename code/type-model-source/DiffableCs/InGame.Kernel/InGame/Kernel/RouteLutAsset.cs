namespace InGame.Kernel;

[Token(Token = "0x20000A6")]
public class RouteLutAsset : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40004F9")]
	private string _routeName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40004FA")]
	private float _maxError; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x40004FB")]
	private int _overrideSampleCount; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40004FC")]
	private Single[] _t; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40004FD")]
	private Vector3[] _positions; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40004FE")]
	private Vector3[] _tangents; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40004FF")]
	private Vector3[] _upVectors; //Field offset: 0x40

	[Token(Token = "0x17000129")]
	public float MaxError
	{
		[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
		[Token(Token = "0x600060C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700012A")]
	public int OverrideSampleCount
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x600060D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000128")]
	public string RouteName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600060B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700012B")]
	public int SampleCount
	{
		[Address(RVA = "0x1D40690", Offset = "0x1D3FA90", Length = "0x12")]
		[Token(Token = "0x600060E")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x1D405A0", Offset = "0x1D3F9A0", Length = "0xD5")]
	[Token(Token = "0x600061C")]
	public RouteLutAsset() { }

	[Address(RVA = "0x1D3FDE0", Offset = "0x1D3F1E0", Length = "0x167")]
	[Token(Token = "0x6000617")]
	private Vector3 Evaluate(Vector3[] samples, float rate, ref int index) { }

	[Address(RVA = "0x1D3FC70", Offset = "0x1D3F070", Length = "0x166")]
	[Token(Token = "0x6000616")]
	private Vector3 Evaluate(Vector3[] samples, float rate) { }

	[Address(RVA = "0x1D3F5B0", Offset = "0x1D3E9B0", Length = "0x3F")]
	[Token(Token = "0x6000612")]
	public Vector3 EvaluatePosition(float rate, ref int index) { }

	[Address(RVA = "0x1D3F570", Offset = "0x1D3E970", Length = "0x3A")]
	[Token(Token = "0x600060F")]
	public Vector3 EvaluatePosition(float rate) { }

	[Address(RVA = "0x1D3F790", Offset = "0x1D3EB90", Length = "0x195")]
	[Token(Token = "0x6000613")]
	public Vector3 EvaluateTangent(float rate, ref int index) { }

	[Address(RVA = "0x1D3F5F0", Offset = "0x1D3E9F0", Length = "0x191")]
	[Token(Token = "0x6000610")]
	public Vector3 EvaluateTangent(float rate) { }

	[Address(RVA = "0x1D3FAD0", Offset = "0x1D3EED0", Length = "0x191")]
	[Token(Token = "0x6000611")]
	public Vector3 EvaluateUpVector(float rate) { }

	[Address(RVA = "0x1D3F930", Offset = "0x1D3ED30", Length = "0x195")]
	[Token(Token = "0x6000614")]
	public Vector3 EvaluateUpVector(float rate, ref int index) { }

	[Address(RVA = "0x1D3FF50", Offset = "0x1D3F350", Length = "0x8C")]
	[Token(Token = "0x600061A")]
	private int FindSegmentBinary(float rate, int sampleCount) { }

	[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
	[Token(Token = "0x600060C")]
	public float get_MaxError() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x600060D")]
	public int get_OverrideSampleCount() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600060B")]
	public string get_RouteName() { }

	[Address(RVA = "0x1D40690", Offset = "0x1D3FA90", Length = "0x12")]
	[Token(Token = "0x600060E")]
	public int get_SampleCount() { }

	[Address(RVA = "0x1D3FFE0", Offset = "0x1D3F3E0", Length = "0xFB")]
	[Token(Token = "0x600061B")]
	private static Vector3 NormalizeSafe(Vector3 value, Vector3 fallback) { }

	[Address(RVA = "0x1D400E0", Offset = "0x1D3F4E0", Length = "0x124")]
	[Token(Token = "0x6000615")]
	public void SetData(string routeName, Single[] t, Vector3[] positions, Vector3[] tangents, Vector3[] upVectors) { }

	[Address(RVA = "0x1D403F0", Offset = "0x1D3F7F0", Length = "0x1A2")]
	[Token(Token = "0x6000618")]
	private bool TryGetLerp(float rate, Vector3[] samples, out int index, out float fraction) { }

	[Address(RVA = "0x1D40210", Offset = "0x1D3F610", Length = "0x1D7")]
	[Token(Token = "0x6000619")]
	private bool TryGetLerpWithIndex(float rate, Vector3[] samples, ref int index, out float fraction) { }

}

