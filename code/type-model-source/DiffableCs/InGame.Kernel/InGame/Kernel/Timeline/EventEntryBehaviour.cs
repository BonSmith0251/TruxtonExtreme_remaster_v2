namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000F0")]
public class EventEntryBehaviour : PlayableBehaviour
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000677")]
	private EventEntryClip _mclip; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000678")]
	private TLEventType _eventType; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000679")]
	private Kind _itemValue; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400067A")]
	private int _intValue; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400067B")]
	private float _floatValue; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400067C")]
	private string _strValue; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400067D")]
	private Vector3 _vecValue; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400067E")]
	private bool _isDrops; //Field offset: 0x3C
	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x400067F")]
	private bool _isDisplay; //Field offset: 0x3D
	[FieldOffset(Offset = "0x3E")]
	[Token(Token = "0x4000680")]
	private bool _isDone; //Field offset: 0x3E

	[Address(RVA = "0x1D370F0", Offset = "0x1D364F0", Length = "0x282")]
	[Token(Token = "0x60007B3")]
	private void _eventFire(float gettime) { }

	[Address(RVA = "0x1D37380", Offset = "0x1D36780", Length = "0xE0")]
	[Token(Token = "0x60007B4")]
	private void _eventStop() { }

	[Address(RVA = "0x1D370B0", Offset = "0x1D364B0", Length = "0x36")]
	[Token(Token = "0x60007B7")]
	public EventEntryBehaviour() { }

	[Address(RVA = "0x1D36BB0", Offset = "0x1D35FB0", Length = "0x98")]
	[Token(Token = "0x60007B5")]
	private string GetCustomString(int tkind) { }

	[Address(RVA = "0x1D36C50", Offset = "0x1D36050", Length = "0xA0")]
	[Token(Token = "0x60007B6")]
	private Kind GetDropItem() { }

	[Address(RVA = "0x1D36D00", Offset = "0x1D36100", Length = "0x7")]
	[Token(Token = "0x60007AF")]
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	[Address(RVA = "0x1D36D10", Offset = "0x1D36110", Length = "0xA3")]
	[Token(Token = "0x60007AE")]
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	[Address(RVA = "0x1D36DC0", Offset = "0x1D361C0", Length = "0x1A")]
	[Token(Token = "0x60007B0")]
	public virtual void OnGraphStop(Playable playable) { }

	[Address(RVA = "0x1D36DE0", Offset = "0x1D361E0", Length = "0x129")]
	[Token(Token = "0x60007B1")]
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	[Address(RVA = "0x1D36F10", Offset = "0x1D36310", Length = "0x194")]
	[Token(Token = "0x60007B2")]
	public void Set(EventEntryClip tclip) { }

}

