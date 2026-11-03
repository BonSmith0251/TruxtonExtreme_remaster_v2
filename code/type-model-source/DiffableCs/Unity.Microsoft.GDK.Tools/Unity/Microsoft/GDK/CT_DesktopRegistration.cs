namespace Unity.Microsoft.GDK;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("xsd", "4.8.3928.0")]
[Token(Token = "0x2000019")]
public class CT_DesktopRegistration : INotifyPropertyChanged
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400006E")]
	private ST_ProcessorArchitecture[] processorArchitectureField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400006F")]
	private CT_DesktopRegistrationMainPackageDependency[] mainPackageDependencyField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000070")]
	private CT_DependencyList[] dependencyListField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000071")]
	private CT_CustomInstallActions[] customInstallActionsField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000072")]
	private CT_DesktopRegistrationModFolder[] modFolderField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000073")]
	private Boolean[] disableRegistryWriteVirtualizationField; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000074")]
	private Boolean[] disableFilesystemWriteVirtualizationField; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000075")]
	private Boolean[] enableWritesToPackageRootField; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000076")]
	private CT_DesktopRegistrationMultiplayerProtocol[] multiplayerProtocolField; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000077")]
	private CT_FileTypeAssociation[] fileTypeAssociationField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000078")]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x60

	[Token(Token = "0x14000014")]
	public override event PropertyChangedEventHandler PropertyChanged
	{
		[Address(RVA = "0x2B653B0", Offset = "0x2B647B0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000F3")]
		 add { } //Length: 158
		[Address(RVA = "0x2B65450", Offset = "0x2B64850", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60000F4")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700004C")]
	[XmlElement("CustomInstallActions")]
	public CT_CustomInstallActions[] CustomInstallActions
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60000E5")]
		 get { } //Length: 5
		[Address(RVA = "0x2B654F0", Offset = "0x2B648F0", Length = "0x58")]
		[Token(Token = "0x60000E6")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700004B")]
	[XmlElement("DependencyList")]
	public CT_DependencyList[] DependencyList
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60000E3")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65550", Offset = "0x2B64950", Length = "0x58")]
		[Token(Token = "0x60000E4")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700004F")]
	[XmlElement("DisableFilesystemWriteVirtualization")]
	public Boolean[] DisableFilesystemWriteVirtualization
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60000EB")]
		 get { } //Length: 5
		[Address(RVA = "0x2B655B0", Offset = "0x2B649B0", Length = "0x58")]
		[Token(Token = "0x60000EC")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700004E")]
	[XmlElement("DisableRegistryWriteVirtualization")]
	public Boolean[] DisableRegistryWriteVirtualization
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60000E9")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65610", Offset = "0x2B64A10", Length = "0x58")]
		[Token(Token = "0x60000EA")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000050")]
	[XmlElement("EnableWritesToPackageRoot")]
	public Boolean[] EnableWritesToPackageRoot
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60000ED")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65670", Offset = "0x2B64A70", Length = "0x58")]
		[Token(Token = "0x60000EE")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000052")]
	[XmlElement("FileTypeAssociation")]
	public CT_FileTypeAssociation[] FileTypeAssociation
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60000F1")]
		 get { } //Length: 5
		[Address(RVA = "0x2B656D0", Offset = "0x2B64AD0", Length = "0x58")]
		[Token(Token = "0x60000F2")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700004A")]
	[XmlElement("MainPackageDependency")]
	public CT_DesktopRegistrationMainPackageDependency[] MainPackageDependency
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60000E1")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65730", Offset = "0x2B64B30", Length = "0x58")]
		[Token(Token = "0x60000E2")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700004D")]
	[XmlElement("ModFolder")]
	public CT_DesktopRegistrationModFolder[] ModFolder
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60000E7")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65790", Offset = "0x2B64B90", Length = "0x58")]
		[Token(Token = "0x60000E8")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000051")]
	[XmlElement("MultiplayerProtocol")]
	public CT_DesktopRegistrationMultiplayerProtocol[] MultiplayerProtocol
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60000EF")]
		 get { } //Length: 5
		[Address(RVA = "0x2B657F0", Offset = "0x2B64BF0", Length = "0x58")]
		[Token(Token = "0x60000F0")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000049")]
	[XmlElement("ProcessorArchitecture")]
	public ST_ProcessorArchitecture[] ProcessorArchitecture
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000DF")]
		 get { } //Length: 5
		[Address(RVA = "0x2B65850", Offset = "0x2B64C50", Length = "0x58")]
		[Token(Token = "0x60000E0")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000F6")]
	public CT_DesktopRegistration() { }

	[Address(RVA = "0x2B653B0", Offset = "0x2B647B0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000F3")]
	public override void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60000E5")]
	public CT_CustomInstallActions[] get_CustomInstallActions() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60000E3")]
	public CT_DependencyList[] get_DependencyList() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60000EB")]
	public Boolean[] get_DisableFilesystemWriteVirtualization() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60000E9")]
	public Boolean[] get_DisableRegistryWriteVirtualization() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60000ED")]
	public Boolean[] get_EnableWritesToPackageRoot() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60000F1")]
	public CT_FileTypeAssociation[] get_FileTypeAssociation() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60000E1")]
	public CT_DesktopRegistrationMainPackageDependency[] get_MainPackageDependency() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60000E7")]
	public CT_DesktopRegistrationModFolder[] get_ModFolder() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60000EF")]
	public CT_DesktopRegistrationMultiplayerProtocol[] get_MultiplayerProtocol() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000DF")]
	public ST_ProcessorArchitecture[] get_ProcessorArchitecture() { }

	[Address(RVA = "0x2B65320", Offset = "0x2B64720", Length = "0x86")]
	[Token(Token = "0x60000F5")]
	protected void RaisePropertyChanged(string propertyName) { }

	[Address(RVA = "0x2B65450", Offset = "0x2B64850", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60000F4")]
	public override void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[Address(RVA = "0x2B654F0", Offset = "0x2B648F0", Length = "0x58")]
	[Token(Token = "0x60000E6")]
	public void set_CustomInstallActions(CT_CustomInstallActions[] value) { }

	[Address(RVA = "0x2B65550", Offset = "0x2B64950", Length = "0x58")]
	[Token(Token = "0x60000E4")]
	public void set_DependencyList(CT_DependencyList[] value) { }

	[Address(RVA = "0x2B655B0", Offset = "0x2B649B0", Length = "0x58")]
	[Token(Token = "0x60000EC")]
	public void set_DisableFilesystemWriteVirtualization(Boolean[] value) { }

	[Address(RVA = "0x2B65610", Offset = "0x2B64A10", Length = "0x58")]
	[Token(Token = "0x60000EA")]
	public void set_DisableRegistryWriteVirtualization(Boolean[] value) { }

	[Address(RVA = "0x2B65670", Offset = "0x2B64A70", Length = "0x58")]
	[Token(Token = "0x60000EE")]
	public void set_EnableWritesToPackageRoot(Boolean[] value) { }

	[Address(RVA = "0x2B656D0", Offset = "0x2B64AD0", Length = "0x58")]
	[Token(Token = "0x60000F2")]
	public void set_FileTypeAssociation(CT_FileTypeAssociation[] value) { }

	[Address(RVA = "0x2B65730", Offset = "0x2B64B30", Length = "0x58")]
	[Token(Token = "0x60000E2")]
	public void set_MainPackageDependency(CT_DesktopRegistrationMainPackageDependency[] value) { }

	[Address(RVA = "0x2B65790", Offset = "0x2B64B90", Length = "0x58")]
	[Token(Token = "0x60000E8")]
	public void set_ModFolder(CT_DesktopRegistrationModFolder[] value) { }

	[Address(RVA = "0x2B657F0", Offset = "0x2B64BF0", Length = "0x58")]
	[Token(Token = "0x60000F0")]
	public void set_MultiplayerProtocol(CT_DesktopRegistrationMultiplayerProtocol[] value) { }

	[Address(RVA = "0x2B65850", Offset = "0x2B64C50", Length = "0x58")]
	[Token(Token = "0x60000E0")]
	public void set_ProcessorArchitecture(ST_ProcessorArchitecture[] value) { }

}

