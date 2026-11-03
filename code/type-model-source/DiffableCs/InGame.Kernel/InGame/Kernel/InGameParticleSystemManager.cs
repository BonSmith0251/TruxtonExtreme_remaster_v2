namespace InGame.Kernel;

[Token(Token = "0x200007F")]
public class InGameParticleSystemManager
{
	[Token(Token = "0x2000080")]
	internal enum PlayLayer : int
	{
		inGameMain = 0,
		hitStop = 1,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400041D")]
	private List<List`1<ParticleSystem>> _pools; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400041E")]
	private List<List`1<InGameObjectBase>> _poolobjs; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400041F")]
	private List<Single> _timeRates; //Field offset: 0x20

	[Address(RVA = "0x1D20790", Offset = "0x1D1FB90", Length = "0x96")]
	[Token(Token = "0x60004F2")]
	private bool _isContain(ParticleSystem ps, PlayLayer layer) { }

	[Address(RVA = "0x1D20830", Offset = "0x1D1FC30", Length = "0x96")]
	[Token(Token = "0x60004F3")]
	private bool _isContain(InGameObjectBase tobj, PlayLayer layer) { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60004F4")]
	public InGameParticleSystemManager() { }

	[Address(RVA = "0x1D1EDF0", Offset = "0x1D1E1F0", Length = "0x3BA")]
	[Token(Token = "0x60004EF")]
	public void ChangeSpeed(float speed, PlayLayer layer) { }

	[Address(RVA = "0x1D1F490", Offset = "0x1D1E890", Length = "0x157")]
	[Token(Token = "0x60004E9")]
	public void Entry(ParticleSystem ps, PlayLayer layer) { }

	[Address(RVA = "0x1D1F2E0", Offset = "0x1D1E6E0", Length = "0x1A9")]
	[Token(Token = "0x60004EA")]
	public void Entry(ParticleSystem[] pss, PlayLayer layer) { }

	[Address(RVA = "0x1D1F1B0", Offset = "0x1D1E5B0", Length = "0x12F")]
	[Token(Token = "0x60004EB")]
	public void Entry(InGameObjectBase inobj, PlayLayer layer) { }

	[Address(RVA = "0x1D1F5F0", Offset = "0x1D1E9F0", Length = "0x4F2")]
	[Token(Token = "0x60004E7")]
	public void Initialize() { }

	[Address(RVA = "0x1D1FD60", Offset = "0x1D1F160", Length = "0x4B0")]
	[Token(Token = "0x60004F1")]
	private void Pause(bool value, PlayLayer layer) { }

	[Address(RVA = "0x1D1FAF0", Offset = "0x1D1EEF0", Length = "0x263")]
	[Token(Token = "0x60004F0")]
	public void PauseAll(bool value) { }

	[Address(RVA = "0x1D203B0", Offset = "0x1D1F7B0", Length = "0x98")]
	[Token(Token = "0x60004EC")]
	public void Remove(ParticleSystem ps, PlayLayer layer) { }

	[Address(RVA = "0x1D202C0", Offset = "0x1D1F6C0", Length = "0xE4")]
	[Token(Token = "0x60004ED")]
	public void Remove(ParticleSystem[] pss, PlayLayer layer) { }

	[Address(RVA = "0x1D20220", Offset = "0x1D1F620", Length = "0x98")]
	[Token(Token = "0x60004EE")]
	public void Remove(InGameObjectBase tobj, PlayLayer layer) { }

	[Address(RVA = "0x1D20450", Offset = "0x1D1F850", Length = "0x333")]
	[Token(Token = "0x60004E8")]
	public void Terminate() { }

}

