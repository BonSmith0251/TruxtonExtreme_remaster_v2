namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000207")]
public class XblContextHandle : EquatableHandle
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000572")]
	internal GCHandle m_gCHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000573")]
	internal XblMultiplayerSessionChangedHandler sessionChangedCallback; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000574")]
	internal XblFunctionContext sessionChangedHandlerId; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000575")]
	internal XblMultiplayerSessionSubscriptionLostHandler sessionSubscriptionLostCallback; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000576")]
	internal XblFunctionContext sessionSubscriptionLostId; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000577")]
	internal XblMultiplayerConnectionIdChangedHandler connectionIdChangedCallback; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000578")]
	internal XblFunctionContext connectionIdChangedId; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000579")]
	internal XblUserStatisticsStatisticChangedHandler statisticChangedCallback; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400057A")]
	internal XblFunctionContext statisiticsAddChangeId; //Field offset: 0x60

	[Token(Token = "0x14000004")]
	public event XblMultiplayerConnectionIdChangedHandler XblMultiplayerConnectionIdChanged
	{
		[Address(RVA = "0x2B859D0", Offset = "0x2B84DD0", Length = "0x125")]
		[Token(Token = "0x6000AB5")]
		 add { } //Length: 293
		[Address(RVA = "0x2B85E90", Offset = "0x2B85290", Length = "0xBB")]
		[Token(Token = "0x6000AB6")]
		 remove { } //Length: 187
	}

	[Token(Token = "0x14000002")]
	public event XblMultiplayerSessionChangedHandler XblMultiplayerSessionChanged
	{
		[Address(RVA = "0x2B85B00", Offset = "0x2B84F00", Length = "0x125")]
		[Token(Token = "0x6000AB1")]
		 add { } //Length: 293
		[Address(RVA = "0x2B85F50", Offset = "0x2B85350", Length = "0xBB")]
		[Token(Token = "0x6000AB2")]
		 remove { } //Length: 187
	}

	[Token(Token = "0x14000003")]
	public event XblMultiplayerSessionSubscriptionLostHandler XblMultiplayerSessionSubscriptionLost
	{
		[Address(RVA = "0x2B85C30", Offset = "0x2B85030", Length = "0x125")]
		[Token(Token = "0x6000AB3")]
		 add { } //Length: 293
		[Address(RVA = "0x2B86010", Offset = "0x2B85410", Length = "0xBB")]
		[Token(Token = "0x6000AB4")]
		 remove { } //Length: 187
	}

	[Token(Token = "0x14000005")]
	public event XblUserStatisticsStatisticChangedHandler XblUserStatisticsStatisticChanged
	{
		[Address(RVA = "0x2B85D60", Offset = "0x2B85160", Length = "0x125")]
		[Token(Token = "0x6000AB7")]
		 add { } //Length: 293
		[Address(RVA = "0x2B860D0", Offset = "0x2B854D0", Length = "0xC9")]
		[Token(Token = "0x6000AB8")]
		 remove { } //Length: 201
	}

	[Token(Token = "0x170001EB")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000ABB")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000AB9")]
	internal XblContextHandle(XblContextHandle interopHandle) { }

	[Address(RVA = "0x2B859D0", Offset = "0x2B84DD0", Length = "0x125")]
	[Token(Token = "0x6000AB5")]
	public void add_XblMultiplayerConnectionIdChanged(XblMultiplayerConnectionIdChangedHandler value) { }

	[Address(RVA = "0x2B85B00", Offset = "0x2B84F00", Length = "0x125")]
	[Token(Token = "0x6000AB1")]
	public void add_XblMultiplayerSessionChanged(XblMultiplayerSessionChangedHandler value) { }

	[Address(RVA = "0x2B85C30", Offset = "0x2B85030", Length = "0x125")]
	[Token(Token = "0x6000AB3")]
	public void add_XblMultiplayerSessionSubscriptionLost(XblMultiplayerSessionSubscriptionLostHandler value) { }

	[Address(RVA = "0x2B85D60", Offset = "0x2B85160", Length = "0x125")]
	[Token(Token = "0x6000AB7")]
	public void add_XblUserStatisticsStatisticChanged(XblUserStatisticsStatisticChangedHandler value) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000ABB")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B84DE0", Offset = "0x2B841E0", Length = "0x4A5")]
	[Token(Token = "0x6000ABA")]
	protected virtual bool ReleaseHandle() { }

	[Address(RVA = "0x2B85E90", Offset = "0x2B85290", Length = "0xBB")]
	[Token(Token = "0x6000AB6")]
	public void remove_XblMultiplayerConnectionIdChanged(XblMultiplayerConnectionIdChangedHandler value) { }

	[Address(RVA = "0x2B85F50", Offset = "0x2B85350", Length = "0xBB")]
	[Token(Token = "0x6000AB2")]
	public void remove_XblMultiplayerSessionChanged(XblMultiplayerSessionChangedHandler value) { }

	[Address(RVA = "0x2B86010", Offset = "0x2B85410", Length = "0xBB")]
	[Token(Token = "0x6000AB4")]
	public void remove_XblMultiplayerSessionSubscriptionLost(XblMultiplayerSessionSubscriptionLostHandler value) { }

	[Address(RVA = "0x2B860D0", Offset = "0x2B854D0", Length = "0xC9")]
	[Token(Token = "0x6000AB8")]
	public void remove_XblUserStatisticsStatisticChanged(XblUserStatisticsStatisticChangedHandler value) { }

	[Address(RVA = "0x2B85290", Offset = "0x2B84690", Length = "0xFD")]
	[MonoPInvokeCallback]
	[Token(Token = "0x6000AAF")]
	private static void XblMultiplayerConnectionIdChangedCallback(IntPtr context) { }

	[Address(RVA = "0x2B85390", Offset = "0x2B84790", Length = "0x3A2")]
	[MonoPInvokeCallback]
	[Token(Token = "0x6000AAD")]
	private static void XblMultiplayerSessionChangedCallback(IntPtr context, XblMultiplayerSessionChangeEventArgs args) { }

	[Address(RVA = "0x2B85740", Offset = "0x2B84B40", Length = "0xFD")]
	[MonoPInvokeCallback]
	[Token(Token = "0x6000AAE")]
	private static void XblMultiplayerSessionSubscriptionLostCallback(IntPtr context) { }

	[Address(RVA = "0x2B85840", Offset = "0x2B84C40", Length = "0x18F")]
	[MonoPInvokeCallback]
	[Token(Token = "0x6000AB0")]
	private static void XblUserStatisticsAddChangedCallback(XblStatisticChangeEventArgs args, IntPtr context) { }

}

