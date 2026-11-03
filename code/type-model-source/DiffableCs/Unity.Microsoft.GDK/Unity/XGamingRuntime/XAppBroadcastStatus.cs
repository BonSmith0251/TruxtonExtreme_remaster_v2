namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20000FB")]
public class XAppBroadcastStatus
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001CC")]
	internal XAppBroadcastStatus interop; //Field offset: 0x10

	[Obsolete("Please use CanStartBroadcast instead, (UnityUpgradable) -> CanStartBroadcast", True)]
	[Token(Token = "0x17000033")]
	public bool canStartBroadcast
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x60005CE")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[Token(Token = "0x60005CF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002A")]
	public bool CanStartBroadcast
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x60005BC")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[Token(Token = "0x60005BD")]
		 set { } //Length: 4
	}

	[Obsolete("Please use IsAnyAppBroadcasting instead, (UnityUpgradable) -> IsAnyAppBroadcasting", True)]
	[Token(Token = "0x17000034")]
	public bool isAnyAppBroadcasting
	{
		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[Token(Token = "0x60005D0")]
		 get { } //Length: 5
		[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
		[Token(Token = "0x60005D1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002B")]
	public bool IsAnyAppBroadcasting
	{
		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[Token(Token = "0x60005BE")]
		 get { } //Length: 5
		[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
		[Token(Token = "0x60005BF")]
		 set { } //Length: 4
	}

	[Obsolete("Please use IsAppInactive instead, (UnityUpgradable) -> IsAppInactive", True)]
	[Token(Token = "0x17000038")]
	public bool isAppInactive
	{
		[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
		[Token(Token = "0x60005D8")]
		 get { } //Length: 5
		[Address(RVA = "0x1F8C9F0", Offset = "0x1F8BDF0", Length = "0x4")]
		[Token(Token = "0x60005D9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002F")]
	public bool IsAppInactive
	{
		[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
		[Token(Token = "0x60005C6")]
		 get { } //Length: 5
		[Address(RVA = "0x1F8C9F0", Offset = "0x1F8BDF0", Length = "0x4")]
		[Token(Token = "0x60005C7")]
		 set { } //Length: 4
	}

	[Obsolete("Please use IsBlockedForApp instead, (UnityUpgradable) -> IsBlockedForApp", True)]
	[Token(Token = "0x17000039")]
	public bool isBlockedForApp
	{
		[Address(RVA = "0x27BCBD0", Offset = "0x27BBFD0", Length = "0x5")]
		[Token(Token = "0x60005DA")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7BDC0", Offset = "0x2B7B1C0", Length = "0x4")]
		[Token(Token = "0x60005DB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000030")]
	public bool IsBlockedForApp
	{
		[Address(RVA = "0x27BCBD0", Offset = "0x27BBFD0", Length = "0x5")]
		[Token(Token = "0x60005C8")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7BDC0", Offset = "0x2B7B1C0", Length = "0x4")]
		[Token(Token = "0x60005C9")]
		 set { } //Length: 4
	}

	[Obsolete("Please use IsCaptureResourceUnavailable instead, (UnityUpgradable) -> IsCaptureResourceUnavailable", True)]
	[Token(Token = "0x17000035")]
	public bool isCaptureResourceUnavailable
	{
		[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
		[Token(Token = "0x60005D2")]
		 get { } //Length: 5
		[Address(RVA = "0x216CFD0", Offset = "0x216C3D0", Length = "0x4")]
		[Token(Token = "0x60005D3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002C")]
	public bool IsCaptureResourceUnavailable
	{
		[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
		[Token(Token = "0x60005C0")]
		 get { } //Length: 5
		[Address(RVA = "0x216CFD0", Offset = "0x216C3D0", Length = "0x4")]
		[Token(Token = "0x60005C1")]
		 set { } //Length: 4
	}

	[Obsolete("Please use IsDisabledBySystem instead, (UnityUpgradable) -> IsDisabledBySystem", True)]
	[Token(Token = "0x1700003B")]
	public bool isDisabledBySystem
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x60005DE")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[Token(Token = "0x60005DF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000032")]
	public bool IsDisabledBySystem
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x60005CC")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[Token(Token = "0x60005CD")]
		 set { } //Length: 4
	}

	[Obsolete("Please use IsDisabledByUser instead, (UnityUpgradable) -> IsDisabledByUser", True)]
	[Token(Token = "0x1700003A")]
	public bool isDisabledByUser
	{
		[Address(RVA = "0x2B7BDB0", Offset = "0x2B7B1B0", Length = "0x5")]
		[Token(Token = "0x60005DC")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7BDD0", Offset = "0x2B7B1D0", Length = "0x4")]
		[Token(Token = "0x60005DD")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000031")]
	public bool IsDisabledByUser
	{
		[Address(RVA = "0x2B7BDB0", Offset = "0x2B7B1B0", Length = "0x5")]
		[Token(Token = "0x60005CA")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7BDD0", Offset = "0x2B7B1D0", Length = "0x4")]
		[Token(Token = "0x60005CB")]
		 set { } //Length: 4
	}

	[Obsolete("Please use IsGameStreamInProgress instead, (UnityUpgradable) -> IsGameStreamInProgress", True)]
	[Token(Token = "0x17000036")]
	public bool isGameStreamInProgress
	{
		[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
		[Token(Token = "0x60005D4")]
		 get { } //Length: 5
		[Address(RVA = "0x21C1120", Offset = "0x21C0520", Length = "0x4")]
		[Token(Token = "0x60005D5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002D")]
	public bool IsGameStreamInProgress
	{
		[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
		[Token(Token = "0x60005C2")]
		 get { } //Length: 5
		[Address(RVA = "0x21C1120", Offset = "0x21C0520", Length = "0x4")]
		[Token(Token = "0x60005C3")]
		 set { } //Length: 4
	}

	[Obsolete("Please use IsGpuConstrained instead, (UnityUpgradable) -> IsGpuConstrained", True)]
	[Token(Token = "0x17000037")]
	public bool isGpuConstrained
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x60005D6")]
		 get { } //Length: 5
		[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
		[Token(Token = "0x60005D7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002E")]
	public bool IsGpuConstrained
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x60005C4")]
		 get { } //Length: 5
		[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
		[Token(Token = "0x60005C5")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2B7BD70", Offset = "0x2B7B170", Length = "0x32")]
	[Token(Token = "0x60005BA")]
	internal XAppBroadcastStatus(XAppBroadcastStatus interop) { }

	[Address(RVA = "0x2B7BD50", Offset = "0x2B7B150", Length = "0x1F")]
	[Token(Token = "0x60005BB")]
	public XAppBroadcastStatus() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x60005CE")]
	public bool get_canStartBroadcast() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x60005BC")]
	public bool get_CanStartBroadcast() { }

	[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
	[Token(Token = "0x60005D0")]
	public bool get_isAnyAppBroadcasting() { }

	[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
	[Token(Token = "0x60005BE")]
	public bool get_IsAnyAppBroadcasting() { }

	[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
	[Token(Token = "0x60005D8")]
	public bool get_isAppInactive() { }

	[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
	[Token(Token = "0x60005C6")]
	public bool get_IsAppInactive() { }

	[Address(RVA = "0x27BCBD0", Offset = "0x27BBFD0", Length = "0x5")]
	[Token(Token = "0x60005DA")]
	public bool get_isBlockedForApp() { }

	[Address(RVA = "0x27BCBD0", Offset = "0x27BBFD0", Length = "0x5")]
	[Token(Token = "0x60005C8")]
	public bool get_IsBlockedForApp() { }

	[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
	[Token(Token = "0x60005D2")]
	public bool get_isCaptureResourceUnavailable() { }

	[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
	[Token(Token = "0x60005C0")]
	public bool get_IsCaptureResourceUnavailable() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x60005DE")]
	public bool get_isDisabledBySystem() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x60005CC")]
	public bool get_IsDisabledBySystem() { }

	[Address(RVA = "0x2B7BDB0", Offset = "0x2B7B1B0", Length = "0x5")]
	[Token(Token = "0x60005DC")]
	public bool get_isDisabledByUser() { }

	[Address(RVA = "0x2B7BDB0", Offset = "0x2B7B1B0", Length = "0x5")]
	[Token(Token = "0x60005CA")]
	public bool get_IsDisabledByUser() { }

	[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
	[Token(Token = "0x60005D4")]
	public bool get_isGameStreamInProgress() { }

	[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
	[Token(Token = "0x60005C2")]
	public bool get_IsGameStreamInProgress() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x60005D6")]
	public bool get_isGpuConstrained() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x60005C4")]
	public bool get_IsGpuConstrained() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[Token(Token = "0x60005CF")]
	public void set_canStartBroadcast(bool value) { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[Token(Token = "0x60005BD")]
	public void set_CanStartBroadcast(bool value) { }

	[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
	[Token(Token = "0x60005D1")]
	public void set_isAnyAppBroadcasting(bool value) { }

	[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
	[Token(Token = "0x60005BF")]
	public void set_IsAnyAppBroadcasting(bool value) { }

	[Address(RVA = "0x1F8C9F0", Offset = "0x1F8BDF0", Length = "0x4")]
	[Token(Token = "0x60005D9")]
	public void set_isAppInactive(bool value) { }

	[Address(RVA = "0x1F8C9F0", Offset = "0x1F8BDF0", Length = "0x4")]
	[Token(Token = "0x60005C7")]
	public void set_IsAppInactive(bool value) { }

	[Address(RVA = "0x2B7BDC0", Offset = "0x2B7B1C0", Length = "0x4")]
	[Token(Token = "0x60005DB")]
	public void set_isBlockedForApp(bool value) { }

	[Address(RVA = "0x2B7BDC0", Offset = "0x2B7B1C0", Length = "0x4")]
	[Token(Token = "0x60005C9")]
	public void set_IsBlockedForApp(bool value) { }

	[Address(RVA = "0x216CFD0", Offset = "0x216C3D0", Length = "0x4")]
	[Token(Token = "0x60005D3")]
	public void set_isCaptureResourceUnavailable(bool value) { }

	[Address(RVA = "0x216CFD0", Offset = "0x216C3D0", Length = "0x4")]
	[Token(Token = "0x60005C1")]
	public void set_IsCaptureResourceUnavailable(bool value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[Token(Token = "0x60005DF")]
	public void set_isDisabledBySystem(bool value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[Token(Token = "0x60005CD")]
	public void set_IsDisabledBySystem(bool value) { }

	[Address(RVA = "0x2B7BDD0", Offset = "0x2B7B1D0", Length = "0x4")]
	[Token(Token = "0x60005DD")]
	public void set_isDisabledByUser(bool value) { }

	[Address(RVA = "0x2B7BDD0", Offset = "0x2B7B1D0", Length = "0x4")]
	[Token(Token = "0x60005CB")]
	public void set_IsDisabledByUser(bool value) { }

	[Address(RVA = "0x21C1120", Offset = "0x21C0520", Length = "0x4")]
	[Token(Token = "0x60005D5")]
	public void set_isGameStreamInProgress(bool value) { }

	[Address(RVA = "0x21C1120", Offset = "0x21C0520", Length = "0x4")]
	[Token(Token = "0x60005C3")]
	public void set_IsGameStreamInProgress(bool value) { }

	[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
	[Token(Token = "0x60005D7")]
	public void set_isGpuConstrained(bool value) { }

	[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
	[Token(Token = "0x60005C5")]
	public void set_IsGpuConstrained(bool value) { }

}

