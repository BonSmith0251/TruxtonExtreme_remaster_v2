namespace UnityEngine.Timeline;

[Token(Token = "0x200003F")]
internal abstract class RuntimeClipBase : RuntimeElement
{

	[Token(Token = "0x170000AA")]
	public abstract double duration
	{
		[Token(Token = "0x600025F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000AC")]
	public virtual long intervalEnd
	{
		[Address(RVA = "0x2F30130", Offset = "0x2F2F530", Length = "0xC4")]
		[Token(Token = "0x6000261")]
		 get { } //Length: 196
	}

	[Token(Token = "0x170000AB")]
	public virtual long intervalStart
	{
		[Address(RVA = "0x2F30200", Offset = "0x2F2F600", Length = "0x9D")]
		[Token(Token = "0x6000260")]
		 get { } //Length: 157
	}

	[Token(Token = "0x170000A9")]
	public abstract double start
	{
		[Token(Token = "0x600025E")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000262")]
	protected RuntimeClipBase() { }

	[Token(Token = "0x600025F")]
	public abstract double get_duration() { }

	[Address(RVA = "0x2F30130", Offset = "0x2F2F530", Length = "0xC4")]
	[Token(Token = "0x6000261")]
	public virtual long get_intervalEnd() { }

	[Address(RVA = "0x2F30200", Offset = "0x2F2F600", Length = "0x9D")]
	[Token(Token = "0x6000260")]
	public virtual long get_intervalStart() { }

	[Token(Token = "0x600025E")]
	public abstract double get_start() { }

}

