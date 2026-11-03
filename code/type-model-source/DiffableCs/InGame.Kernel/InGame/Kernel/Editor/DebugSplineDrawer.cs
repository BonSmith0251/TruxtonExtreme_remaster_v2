namespace InGame.Kernel.Editor;

[Token(Token = "0x200023E")]
public class DebugSplineDrawer : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013D0")]
	private Dictionary<Int32, Spline> _spline; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013D1")]
	private List<GameObject> _lines; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013D2")]
	private bool _isDirty; //Field offset: 0x30

	[Address(RVA = "0x1D13580", Offset = "0x1D12980", Length = "0xBD")]
	[Token(Token = "0x6001131")]
	public DebugSplineDrawer() { }

	[Address(RVA = "0x1D13120", Offset = "0x1D12520", Length = "0x6C")]
	[Token(Token = "0x600112C")]
	public void AddLine(Spline vsp, int tindex) { }

	[Address(RVA = "0x1D13190", Offset = "0x1D12590", Length = "0xC2")]
	[Token(Token = "0x6001129")]
	private void Awake() { }

	[Address(RVA = "0x1D13260", Offset = "0x1D12660", Length = "0x184")]
	[Token(Token = "0x6001130")]
	public void DestoryLines() { }

	[Address(RVA = "0x1D133F0", Offset = "0x1D127F0", Length = "0x4E")]
	[Token(Token = "0x600112B")]
	private void OnDestroy() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600112A")]
	private void OnDrawGizmos() { }

	[Address(RVA = "0x1D13440", Offset = "0x1D12840", Length = "0x11F")]
	[Token(Token = "0x600112F")]
	public void SetActiveLine(bool value) { }

	[Address(RVA = "0xD985F0", Offset = "0xD979F0", Length = "0x5")]
	[Token(Token = "0x600112D")]
	public void SetDirty() { }

	[Address(RVA = "0x1D13560", Offset = "0x1D12960", Length = "0x20")]
	[Token(Token = "0x600112E")]
	public void UpdateLine() { }

}

