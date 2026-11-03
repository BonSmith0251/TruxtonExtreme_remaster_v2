namespace Microsoft.Win32;

[Token(Token = "0x2000076")]
public sealed class RegistryKey : MarshalByRefObject, IDisposable
{
	[Flags]
	[Token(Token = "0x2000077")]
	private enum StateFlags : int
	{
		Dirty = 1,
		SystemKey = 2,
		WriteAccess = 4,
		PerfData = 8,
	}

	[Token(Token = "0x4000219")]
	internal static readonly IntPtr HKEY_CLASSES_ROOT; //Field offset: 0x0
	[Token(Token = "0x400021A")]
	internal static readonly IntPtr HKEY_CURRENT_USER; //Field offset: 0x8
	[Token(Token = "0x400021B")]
	internal static readonly IntPtr HKEY_LOCAL_MACHINE; //Field offset: 0x10
	[Token(Token = "0x400021C")]
	internal static readonly IntPtr HKEY_USERS; //Field offset: 0x18
	[Token(Token = "0x400021D")]
	internal static readonly IntPtr HKEY_PERFORMANCE_DATA; //Field offset: 0x20
	[Token(Token = "0x400021E")]
	internal static readonly IntPtr HKEY_CURRENT_CONFIG; //Field offset: 0x28
	[Token(Token = "0x400021F")]
	internal static readonly IntPtr HKEY_DYN_DATA; //Field offset: 0x30
	[Token(Token = "0x4000220")]
	private static readonly String[] s_hkeyNames; //Field offset: 0x38
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000221")]
	private SafeRegistryHandle _hkey; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000222")]
	private string _keyName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000223")]
	private bool _remoteKey; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000224")]
	private StateFlags _state; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000225")]
	private RegistryKeyPermissionCheck _checkMode; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000226")]
	private RegistryView _regView; //Field offset: 0x34

	[Address(RVA = "0x1E7BDF0", Offset = "0x1E7B1F0", Length = "0x2E5")]
	[Token(Token = "0x600020B")]
	private static RegistryKey() { }

	[Address(RVA = "0x1E7C0E0", Offset = "0x1E7B4E0", Length = "0x178")]
	[Token(Token = "0x60001F9")]
	private RegistryKey(SafeRegistryHandle hkey, bool writable, bool systemkey, bool remoteKey, bool isPerfData, RegistryView view) { }

	[Address(RVA = "0x1E79AB0", Offset = "0x1E78EB0", Length = "0x52")]
	[Token(Token = "0x60001F1")]
	private void ClosePerfDataKey() { }

	[Address(RVA = "0x1E79B10", Offset = "0x1E78F10", Length = "0x118")]
	[Token(Token = "0x60001FA")]
	public override void Dispose() { }

	[Address(RVA = "0x1E79C30", Offset = "0x1E79030", Length = "0x5D")]
	[Token(Token = "0x6000205")]
	private void EnsureNotDisposed() { }

	[Address(RVA = "0x1E79C90", Offset = "0x1E79090", Length = "0x213")]
	[Token(Token = "0x6000203")]
	private static string FixupName(string name) { }

	[Address(RVA = "0x1E79EB0", Offset = "0x1E792B0", Length = "0x12E")]
	[Token(Token = "0x6000204")]
	private static void FixupPath(StringBuilder path) { }

	[Address(RVA = "0x1E79FE0", Offset = "0x1E793E0", Length = "0x12")]
	[Token(Token = "0x60001F8")]
	private static int GetRegistryKeyAccess(bool isWritable) { }

	[Address(RVA = "0x1E7A000", Offset = "0x1E79400", Length = "0x183")]
	[Token(Token = "0x60001FE")]
	public String[] GetSubKeyNames() { }

	[Address(RVA = "0x1E7A190", Offset = "0x1E79590", Length = "0x55")]
	[Token(Token = "0x6000206")]
	private RegistryKeyPermissionCheck GetSubKeyPermissionCheck(bool subkeyWritable) { }

	[Address(RVA = "0x1E7A1F0", Offset = "0x1E795F0", Length = "0x11D")]
	[Token(Token = "0x6000200")]
	public object GetValue(string name, object defaultValue, RegistryValueOptions options) { }

	[Address(RVA = "0x1E7A000", Offset = "0x1E79400", Length = "0x183")]
	[Token(Token = "0x60001FF")]
	private String[] InternalGetSubKeyNames() { }

	[Address(RVA = "0x1E7A310", Offset = "0x1E79710", Length = "0x235")]
	[Token(Token = "0x60001F5")]
	private String[] InternalGetSubKeyNamesCore(int subkeys) { }

	[Address(RVA = "0x1E7AE80", Offset = "0x1E7A280", Length = "0xA8")]
	[Token(Token = "0x6000201")]
	private object InternalGetValue(string name, object defaultValue, bool doNotExpand, bool checkSecurity) { }

	[Address(RVA = "0x1E7A550", Offset = "0x1E79950", Length = "0x8FC")]
	[Token(Token = "0x60001F6")]
	private object InternalGetValueCore(string name, object defaultValue, bool doNotExpand) { }

	[Address(RVA = "0x1E7AF30", Offset = "0x1E7A330", Length = "0x1EC")]
	[Token(Token = "0x60001F3")]
	private RegistryKey InternalOpenSubKeyCore(string name, bool writable, bool throwOnPermissionFailure) { }

	[Address(RVA = "0x1E7B1C0", Offset = "0x1E7A5C0", Length = "0xF6")]
	[Token(Token = "0x60001FD")]
	private int InternalSubKeyCount() { }

	[Address(RVA = "0x1E7B120", Offset = "0x1E7A520", Length = "0x9E")]
	[Token(Token = "0x60001F4")]
	private int InternalSubKeyCountCore() { }

	[Address(RVA = "0x1E7B2C0", Offset = "0x1E7A6C0", Length = "0x1A")]
	[Token(Token = "0x600020A")]
	private bool IsPerfDataKey() { }

	[Address(RVA = "0x1E7B2E0", Offset = "0x1E7A6E0", Length = "0x1A")]
	[Token(Token = "0x6000209")]
	private bool IsSystemKey() { }

	[Address(RVA = "0x1E7B460", Offset = "0x1E7A860", Length = "0x1E5")]
	[Token(Token = "0x60001FB")]
	public static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view) { }

	[Address(RVA = "0x1E7B300", Offset = "0x1E7A700", Length = "0x15B")]
	[Token(Token = "0x60001F2")]
	private static RegistryKey OpenBaseKeyCore(RegistryHive hKeyHive, RegistryView view) { }

	[Address(RVA = "0x1E7B650", Offset = "0x1E7AA50", Length = "0xD8")]
	[Token(Token = "0x60001FC")]
	public RegistryKey OpenSubKey(string name, bool writable) { }

	[Address(RVA = "0x1E7B730", Offset = "0x1E7AB30", Length = "0x60")]
	[Token(Token = "0x6000202")]
	public virtual string ToString() { }

	[Address(RVA = "0x1E7B7A0", Offset = "0x1E7ABA0", Length = "0x443")]
	[Token(Token = "0x6000207")]
	private static void ValidateKeyName(string name) { }

	[Address(RVA = "0x1E7BBF0", Offset = "0x1E7AFF0", Length = "0x5C")]
	[Token(Token = "0x6000208")]
	private static void ValidateKeyView(RegistryView view) { }

	[Address(RVA = "0x1E7BC50", Offset = "0x1E7B050", Length = "0x197")]
	[Token(Token = "0x60001F7")]
	private void Win32Error(int errorCode, string str) { }

}

