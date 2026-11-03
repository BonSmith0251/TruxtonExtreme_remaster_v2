namespace AEAsAnimation;

[Token(Token = "0x200000C")]
public class AEAudio
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000039")]
	private FootageData _footage; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400003A")]
	private IAEAudioPlayer _player; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400003B")]
	private string _baseName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400003C")]
	private string _extension; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400003D")]
	private bool _enable; //Field offset: 0x30

	[Address(RVA = "0x5B0E70", Offset = "0x5B0270", Length = "0x6E")]
	[Token(Token = "0x6000057")]
	public AEAudio() { }

	[Address(RVA = "0x5B09F0", Offset = "0x5AFDF0", Length = "0xC2")]
	[Token(Token = "0x6000055")]
	public void Play(float volume) { }

	[Address(RVA = "0x5B0AC0", Offset = "0x5AFEC0", Length = "0x342")]
	[Token(Token = "0x6000054")]
	public void Setup(FootageData footage, IAEAudioAccessor accessor, bool isFilterEnable) { }

	[Address(RVA = "0x5B0E10", Offset = "0x5B0210", Length = "0x55")]
	[Token(Token = "0x6000056")]
	public void Stop() { }

}

