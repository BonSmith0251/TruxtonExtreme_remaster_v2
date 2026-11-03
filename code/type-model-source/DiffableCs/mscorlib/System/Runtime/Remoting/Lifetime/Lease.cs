namespace System.Runtime.Remoting.Lifetime;

[Token(Token = "0x200036C")]
internal class Lease : MarshalByRefObject, ILease
{
	[Token(Token = "0x200036D")]
	private sealed class RenewalDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1EEE9D0", Offset = "0x1EEDDD0", Length = "0x124")]
		[Token(Token = "0x6001B81")]
		public RenewalDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x6001B83")]
		public override IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, object object) { }

		[Address(RVA = "0x17C9A80", Offset = "0x17C8E80", Length = "0x28")]
		[Token(Token = "0x6001B84")]
		public override TimeSpan EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6001B82")]
		public override TimeSpan Invoke(ILease lease) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E3D")]
	private DateTime _leaseExpireTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E3E")]
	private LeaseState _currentState; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E3F")]
	private TimeSpan _initialLeaseTime; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E40")]
	private TimeSpan _renewOnCallTime; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E41")]
	private TimeSpan _sponsorshipTimeout; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E42")]
	private ArrayList _sponsors; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E43")]
	private Queue _renewingSponsors; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E44")]
	private RenewalDelegate _renewalDelegate; //Field offset: 0x50

	[Token(Token = "0x170002EB")]
	public override TimeSpan CurrentLeaseTime
	{
		[Address(RVA = "0x1EE3F60", Offset = "0x1EE3360", Length = "0x58")]
		[Token(Token = "0x6001B78")]
		 get { } //Length: 88
	}

	[Token(Token = "0x170002EC")]
	public override LeaseState CurrentState
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6001B79")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170002ED")]
	public override TimeSpan RenewOnCallTime
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6001B7B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1EE3DF0", Offset = "0x1EE31F0", Length = "0x167")]
	[Token(Token = "0x6001B77")]
	public Lease() { }

	[Address(RVA = "0x1EE30C0", Offset = "0x1EE24C0", Length = "0x8")]
	[Token(Token = "0x6001B7A")]
	public void Activate() { }

	[Address(RVA = "0x1EE30D0", Offset = "0x1EE24D0", Length = "0x3A4")]
	[Token(Token = "0x6001B7F")]
	private void CheckNextSponsor() { }

	[Address(RVA = "0x1EE3F60", Offset = "0x1EE3360", Length = "0x58")]
	[Token(Token = "0x6001B78")]
	public override TimeSpan get_CurrentLeaseTime() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6001B79")]
	public override LeaseState get_CurrentState() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6001B7B")]
	public override TimeSpan get_RenewOnCallTime() { }

	[Address(RVA = "0x1EE3480", Offset = "0x1EE2880", Length = "0x59C")]
	[Token(Token = "0x6001B80")]
	private void ProcessSponsorResponse(object state, bool timedOut) { }

	[Address(RVA = "0x1EE3A20", Offset = "0x1EE2E20", Length = "0xC4")]
	[Token(Token = "0x6001B7C")]
	public override TimeSpan Renew(TimeSpan renewalTime) { }

	[Address(RVA = "0x1EE3AF0", Offset = "0x1EE2EF0", Length = "0x14A")]
	[Token(Token = "0x6001B7D")]
	public override void Unregister(ISponsor obj) { }

	[Address(RVA = "0x1EE3C40", Offset = "0x1EE3040", Length = "0x1A5")]
	[Token(Token = "0x6001B7E")]
	internal void UpdateState() { }

}

