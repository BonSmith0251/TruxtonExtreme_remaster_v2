namespace UnityEngine.Timeline;

[Token(Token = "0x2000044")]
public abstract class Marker : ScriptableObject, IMarker
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[TimeField(UseEditMode::ApplyEditMode (1))]
	[Token(Token = "0x4000128")]
	[Tooltip("Time for the marker")]
	private double m_Time; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000129")]
	private TrackAsset <parent>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170000BA")]
	public private override TrackAsset parent
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600027B")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600027C")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000BB")]
	public override double time
	{
		[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
		[Token(Token = "0x600027D")]
		 get { } //Length: 6
		[Address(RVA = "0x2F2FE00", Offset = "0x2F2F200", Length = "0x60")]
		[Token(Token = "0x600027E")]
		 set { } //Length: 96
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000281")]
	protected Marker() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600027B")]
	public override TrackAsset get_parent() { }

	[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
	[Token(Token = "0x600027D")]
	public override double get_time() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000280")]
	public override void OnInitialize(TrackAsset aPent) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600027C")]
	private void set_parent(TrackAsset value) { }

	[Address(RVA = "0x2F2FE00", Offset = "0x2F2F200", Length = "0x60")]
	[Token(Token = "0x600027E")]
	public override void set_time(double value) { }

	[Address(RVA = "0x2F2FD10", Offset = "0x2F2F110", Length = "0xEF")]
	[Token(Token = "0x600027F")]
	private override void UnityEngine.Timeline.IMarker.Initialize(TrackAsset parentTrack) { }

}

