namespace InGame.Kernel.Enemy;

[Token(Token = "0x200016C")]
public class EnemyPoser
{
	[Token(Token = "0x200016D")]
	private struct PoseData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A79")]
		public string _parentPath; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A7A")]
		public Vector3 _localPosition; //Field offset: 0x8
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000A7B")]
		public Quaternion _localRotate; //Field offset: 0x14

		[Address(RVA = "0x1D72840", Offset = "0x1D71C40", Length = "0x66")]
		[Token(Token = "0x6000B5A")]
		public PoseData(Transform tt, string tpath) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A78")]
	private Dictionary<String, HashSet`1<PoseData>> _poseDatas; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000B59")]
	public EnemyPoser() { }

	[Address(RVA = "0x1D6D660", Offset = "0x1D6CA60", Length = "0x28B")]
	[Token(Token = "0x6000B56")]
	public void EntryPose(Transform targetRoot) { }

	[Address(RVA = "0x1D6D8F0", Offset = "0x1D6CCF0", Length = "0x6D")]
	[Token(Token = "0x6000B53")]
	public void Initialize() { }

	[Address(RVA = "0x1D6D960", Offset = "0x1D6CD60", Length = "0x112")]
	[Token(Token = "0x6000B57")]
	private bool IsPoseSkipName(string tname) { }

	[Address(RVA = "0x1D6DA80", Offset = "0x1D6CE80", Length = "0x44")]
	[Token(Token = "0x6000B54")]
	public void Reset() { }

	[Address(RVA = "0x1D6DAD0", Offset = "0x1D6CED0", Length = "0x318")]
	[Token(Token = "0x6000B58")]
	public void SetPose(Transform targetRoot) { }

	[Address(RVA = "0x1D6DDF0", Offset = "0x1D6D1F0", Length = "0x57")]
	[Token(Token = "0x6000B55")]
	public void Terminate() { }

}

