//Type is in global namespace

[ExecuteInEditMode]
[Token(Token = "0x2000006")]
public class SplineTimelineMover : MonoBehaviour, ITimeControl
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000012")]
	private SplineContainer _splineContainer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000013")]
	private double _duration; //Field offset: 0x28

	[Address(RVA = "0x5D41E0", Offset = "0x5D35E0", Length = "0x15")]
	[Token(Token = "0x600000E")]
	public SplineTimelineMover() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600000C")]
	public override void OnControlTimeStart() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600000D")]
	public override void OnControlTimeStop() { }

	[Address(RVA = "0x5D40E0", Offset = "0x5D34E0", Length = "0xF6")]
	[Token(Token = "0x600000B")]
	public override void SetTime(double time) { }

}

