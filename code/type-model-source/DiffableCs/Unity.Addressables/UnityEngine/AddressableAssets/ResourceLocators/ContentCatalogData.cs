namespace UnityEngine.AddressableAssets.ResourceLocators;

[Token(Token = "0x2000049")]
public class ContentCatalogData
{
	[Token(Token = "0x2000056")]
	public class AssetBundleRequestOptionsSerializationAdapter : ISerializationAdapter<AssetBundleRequestOptions>, ISerializationAdapter
	{
		[Token(Token = "0x2000057")]
		private struct SerializedData
		{
			[Token(Token = "0x2000058")]
			internal struct Common
			{
				[FieldOffset(Offset = "0x0")]
				[Token(Token = "0x400013B")]
				public short timeout; //Field offset: 0x0
				[FieldOffset(Offset = "0x2")]
				[Token(Token = "0x400013C")]
				public byte redirectLimit; //Field offset: 0x2
				[FieldOffset(Offset = "0x3")]
				[Token(Token = "0x400013D")]
				public byte retryCount; //Field offset: 0x3
				[FieldOffset(Offset = "0x4")]
				[Token(Token = "0x400013E")]
				public int flags; //Field offset: 0x4

				[Token(Token = "0x17000054")]
				public AssetLoadMode assetLoadMode
				{
					[Address(RVA = "0x27A8940", Offset = "0x27A7D40", Length = "0x7")]
					[Token(Token = "0x6000222")]
					 get { } //Length: 7
					[Address(RVA = "0x27A8990", Offset = "0x27A7D90", Length = "0xC")]
					[Token(Token = "0x6000223")]
					 set { } //Length: 12
				}

				[Token(Token = "0x17000055")]
				public bool chunkedTransfer
				{
					[Address(RVA = "0x27A8950", Offset = "0x27A7D50", Length = "0x8")]
					[Token(Token = "0x6000224")]
					 get { } //Length: 8
					[Address(RVA = "0x27A89A0", Offset = "0x27A7DA0", Length = "0x17")]
					[Token(Token = "0x6000225")]
					 set { } //Length: 23
				}

				[Token(Token = "0x17000058")]
				public bool clearOtherCachedVersionsWhenLoaded
				{
					[Address(RVA = "0x27A8960", Offset = "0x27A7D60", Length = "0x9")]
					[Token(Token = "0x600022A")]
					 get { } //Length: 9
					[Address(RVA = "0x27A89C0", Offset = "0x27A7DC0", Length = "0x18")]
					[Token(Token = "0x600022B")]
					 set { } //Length: 24
				}

				[Token(Token = "0x17000056")]
				public bool useCrcForCachedBundle
				{
					[Address(RVA = "0x27A8970", Offset = "0x27A7D70", Length = "0x9")]
					[Token(Token = "0x6000226")]
					 get { } //Length: 9
					[Address(RVA = "0x27A89E0", Offset = "0x27A7DE0", Length = "0x18")]
					[Token(Token = "0x6000227")]
					 set { } //Length: 24
				}

				[Token(Token = "0x17000057")]
				public bool useUnityWebRequestForLocalBundles
				{
					[Address(RVA = "0x27A8980", Offset = "0x27A7D80", Length = "0x9")]
					[Token(Token = "0x6000228")]
					 get { } //Length: 9
					[Address(RVA = "0x27A8A00", Offset = "0x27A7E00", Length = "0x18")]
					[Token(Token = "0x6000229")]
					 set { } //Length: 24
				}

				[Address(RVA = "0x27A8940", Offset = "0x27A7D40", Length = "0x7")]
				[Token(Token = "0x6000222")]
				public AssetLoadMode get_assetLoadMode() { }

				[Address(RVA = "0x27A8950", Offset = "0x27A7D50", Length = "0x8")]
				[Token(Token = "0x6000224")]
				public bool get_chunkedTransfer() { }

				[Address(RVA = "0x27A8960", Offset = "0x27A7D60", Length = "0x9")]
				[Token(Token = "0x600022A")]
				public bool get_clearOtherCachedVersionsWhenLoaded() { }

				[Address(RVA = "0x27A8970", Offset = "0x27A7D70", Length = "0x9")]
				[Token(Token = "0x6000226")]
				public bool get_useCrcForCachedBundle() { }

				[Address(RVA = "0x27A8980", Offset = "0x27A7D80", Length = "0x9")]
				[Token(Token = "0x6000228")]
				public bool get_useUnityWebRequestForLocalBundles() { }

				[Address(RVA = "0x27A8990", Offset = "0x27A7D90", Length = "0xC")]
				[Token(Token = "0x6000223")]
				public void set_assetLoadMode(AssetLoadMode value) { }

				[Address(RVA = "0x27A89A0", Offset = "0x27A7DA0", Length = "0x17")]
				[Token(Token = "0x6000225")]
				public void set_chunkedTransfer(bool value) { }

				[Address(RVA = "0x27A89C0", Offset = "0x27A7DC0", Length = "0x18")]
				[Token(Token = "0x600022B")]
				public void set_clearOtherCachedVersionsWhenLoaded(bool value) { }

				[Address(RVA = "0x27A89E0", Offset = "0x27A7DE0", Length = "0x18")]
				[Token(Token = "0x6000227")]
				public void set_useCrcForCachedBundle(bool value) { }

				[Address(RVA = "0x27A8A00", Offset = "0x27A7E00", Length = "0x18")]
				[Token(Token = "0x6000229")]
				public void set_useUnityWebRequestForLocalBundles(bool value) { }

			}

			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000136")]
			public uint hashId; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000137")]
			public uint bundleNameId; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000138")]
			public uint crc; //Field offset: 0x8
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x4000139")]
			public uint bundleSize; //Field offset: 0xC
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400013A")]
			public uint commonId; //Field offset: 0x10

		}


		[Token(Token = "0x17000053")]
		public override IEnumerable<ISerializationAdapter> Dependencies
		{
			[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
			[Token(Token = "0x600021E")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000221")]
		public AssetBundleRequestOptionsSerializationAdapter() { }

		[Address(RVA = "0x27A45B0", Offset = "0x27A39B0", Length = "0x271")]
		[Token(Token = "0x600021F")]
		public override object Deserialize(Reader reader, Type type, uint offset, out uint size) { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600021E")]
		public override IEnumerable<ISerializationAdapter> get_Dependencies() { }

		[Address(RVA = "0x27A4830", Offset = "0x27A3C30", Length = "0x285")]
		[Token(Token = "0x6000220")]
		public override uint Serialize(Writer writer, object obj) { }

	}

	[Token(Token = "0x200004C")]
	public class ResourceLocator : IResourceLocator
	{
		[Token(Token = "0x200004F")]
		public class ContentCatalogDataEntrySerializationContext
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000120")]
			public ContentCatalogDataEntry entry; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000121")]
			public Dictionary<Object, List`1<Int32>> keyToEntryIndices; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000122")]
			public IList<ContentCatalogDataEntry> allEntries; //Field offset: 0x20

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000202")]
			public ContentCatalogDataEntrySerializationContext() { }

		}

		[Token(Token = "0x200004D")]
		internal struct Header
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000116")]
			public int magic; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000117")]
			public int version; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000118")]
			public uint keysOffset; //Field offset: 0x8
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x4000119")]
			public uint idOffset; //Field offset: 0xC
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400011A")]
			public uint instanceProvider; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x400011B")]
			public uint sceneProvider; //Field offset: 0x14
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400011C")]
			public uint initObjectsArray; //Field offset: 0x18
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x400011D")]
			public uint buildResultHash; //Field offset: 0x1C

		}

		[Token(Token = "0x200004E")]
		internal struct KeyData
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400011E")]
			public uint keyNameOffset; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x400011F")]
			public uint locationSetOffset; //Field offset: 0x4

		}

		[Token(Token = "0x2000055")]
		private class LocateProcContext
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000134")]
			public IList<IResourceLocation> locations; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000135")]
			public Type type; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600021D")]
			public LocateProcContext() { }

		}

		[Token(Token = "0x2000050")]
		public class ResourceLocation : IResourceLocation
		{
			[Token(Token = "0x2000051")]
			private class ResolvedInternalId
			{
				[FieldOffset(Offset = "0x10")]
				[Token(Token = "0x400012B")]
				public string InternalId; //Field offset: 0x10

				[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
				[Token(Token = "0x6000214")]
				public ResolvedInternalId() { }

			}

			[Token(Token = "0x2000052")]
			internal class ResolvedInternalIdSerializer : ISerializationAdapter<ResolvedInternalId>, ISerializationAdapter
			{

				[Token(Token = "0x17000051")]
				private override IEnumerable<ISerializationAdapter> UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter.Dependencies
				{
					[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
					[Token(Token = "0x6000215")]
					private get { } //Length: 3
				}

				[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
				[Token(Token = "0x6000218")]
				public ResolvedInternalIdSerializer() { }

				[Address(RVA = "0x27AFE70", Offset = "0x27AF270", Length = "0xCA")]
				[Token(Token = "0x6000216")]
				private override object UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter.Deserialize(Reader reader, Type t, uint offset, out uint size) { }

				[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
				[Token(Token = "0x6000215")]
				private override IEnumerable<ISerializationAdapter> UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter.get_Dependencies() { }

				[Address(RVA = "0x27AFF40", Offset = "0x27AF340", Length = "0x3E")]
				[Token(Token = "0x6000217")]
				private override uint UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter.Serialize(Writer writer, object val) { }

			}

			[Token(Token = "0x2000053")]
			internal class Serializer : ISerializationAdapter<ResourceLocation>, ISerializationAdapter, ISerializationAdapter<ContentCatalogDataEntrySerializationContext>
			{
				[Token(Token = "0x2000054")]
				internal struct Data
				{
					[FieldOffset(Offset = "0x0")]
					[Token(Token = "0x400012D")]
					public uint primaryKeyOffset; //Field offset: 0x0
					[FieldOffset(Offset = "0x4")]
					[Token(Token = "0x400012E")]
					public uint internalIdOffset; //Field offset: 0x4
					[FieldOffset(Offset = "0x8")]
					[Token(Token = "0x400012F")]
					public uint providerOffset; //Field offset: 0x8
					[FieldOffset(Offset = "0xC")]
					[Token(Token = "0x4000130")]
					public uint dependencySetOffset; //Field offset: 0xC
					[FieldOffset(Offset = "0x10")]
					[Token(Token = "0x4000131")]
					public int dependencyHashValue; //Field offset: 0x10
					[FieldOffset(Offset = "0x14")]
					[Token(Token = "0x4000132")]
					public uint extraDataOffset; //Field offset: 0x14
					[FieldOffset(Offset = "0x18")]
					[Token(Token = "0x4000133")]
					public uint typeId; //Field offset: 0x18

				}

				[FieldOffset(Offset = "0x10")]
				[Token(Token = "0x400012C")]
				private bool resolveInternalIds; //Field offset: 0x10

				[Token(Token = "0x17000052")]
				public override IEnumerable<ISerializationAdapter> Dependencies
				{
					[Address(RVA = "0x27B4910", Offset = "0x27B3D10", Length = "0xBC")]
					[Token(Token = "0x6000219")]
					 get { } //Length: 188
				}

				[Address(RVA = "0x21AF260", Offset = "0x21AE660", Length = "0x26")]
				[Token(Token = "0x600021A")]
				public Serializer(bool resolveInternalIds) { }

				[Address(RVA = "0x27B3680", Offset = "0x27B2A80", Length = "0x84")]
				[Token(Token = "0x600021B")]
				public override object Deserialize(Reader reader, Type t, uint offset, out uint size) { }

				[Address(RVA = "0x27B4910", Offset = "0x27B3D10", Length = "0xBC")]
				[Token(Token = "0x6000219")]
				public override IEnumerable<ISerializationAdapter> get_Dependencies() { }

				[Address(RVA = "0x27B3710", Offset = "0x27B2B10", Length = "0x5FF")]
				[Token(Token = "0x600021C")]
				public override uint Serialize(Writer writer, object val) { }

			}

			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000123")]
			private Reader reader; //Field offset: 0x10
			[CompilerGenerated]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000124")]
			private string <InternalId>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000125")]
			private string <ProviderId>k__BackingField; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000126")]
			private List<IResourceLocation> _deps; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4000127")]
			private uint dependencyDataOffset; //Field offset: 0x30
			[CompilerGenerated]
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x4000128")]
			private object <Data>k__BackingField; //Field offset: 0x38
			[CompilerGenerated]
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x4000129")]
			private string <PrimaryKey>k__BackingField; //Field offset: 0x40
			[CompilerGenerated]
			[FieldOffset(Offset = "0x48")]
			[Token(Token = "0x400012A")]
			private Type <ResourceType>k__BackingField; //Field offset: 0x48

			[Token(Token = "0x1700004E")]
			public internal override object Data
			{
				[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600020C")]
				 get { } //Length: 5
				[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
				[CompilerGenerated]
				[Token(Token = "0x600020D")]
				internal set { } //Length: 13
			}

			[Token(Token = "0x1700004B")]
			public override IList<IResourceLocation> Dependencies
			{
				[Address(RVA = "0x27B18B0", Offset = "0x27B0CB0", Length = "0x11A")]
				[Token(Token = "0x6000209")]
				 get { } //Length: 282
			}

			[Token(Token = "0x1700004C")]
			public override int DependencyHashCode
			{
				[Address(RVA = "0x27B19D0", Offset = "0x27B0DD0", Length = "0xB")]
				[Token(Token = "0x600020A")]
				 get { } //Length: 11
			}

			[Token(Token = "0x1700004D")]
			public override bool HasDependencies
			{
				[Address(RVA = "0x27B19E0", Offset = "0x27B0DE0", Length = "0x8")]
				[Token(Token = "0x600020B")]
				 get { } //Length: 8
			}

			[Token(Token = "0x17000049")]
			public internal override string InternalId
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000204")]
				 get { } //Length: 5
				[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
				[CompilerGenerated]
				[Token(Token = "0x6000205")]
				internal set { } //Length: 13
			}

			[Token(Token = "0x1700004F")]
			public internal override string PrimaryKey
			{
				[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x600020E")]
				 get { } //Length: 5
				[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
				[CompilerGenerated]
				[Token(Token = "0x600020F")]
				internal set { } //Length: 13
			}

			[Token(Token = "0x1700004A")]
			public internal override string ProviderId
			{
				[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000206")]
				 get { } //Length: 5
				[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
				[CompilerGenerated]
				[Token(Token = "0x6000207")]
				internal set { } //Length: 13
			}

			[Token(Token = "0x17000050")]
			public internal override Type ResourceType
			{
				[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x6000210")]
				 get { } //Length: 5
				[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
				[CompilerGenerated]
				[Token(Token = "0x6000211")]
				internal set { } //Length: 13
			}

			[Address(RVA = "0x27B1660", Offset = "0x27B0A60", Length = "0x24C")]
			[Token(Token = "0x6000203")]
			public ResourceLocation(Reader r, uint id, out uint size, bool resolveInternalId) { }

			[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600020C")]
			public override object get_Data() { }

			[Address(RVA = "0x27B18B0", Offset = "0x27B0CB0", Length = "0x11A")]
			[Token(Token = "0x6000209")]
			public override IList<IResourceLocation> get_Dependencies() { }

			[Address(RVA = "0x27B19D0", Offset = "0x27B0DD0", Length = "0xB")]
			[Token(Token = "0x600020A")]
			public override int get_DependencyHashCode() { }

			[Address(RVA = "0x27B19E0", Offset = "0x27B0DE0", Length = "0x8")]
			[Token(Token = "0x600020B")]
			public override bool get_HasDependencies() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000204")]
			public override string get_InternalId() { }

			[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600020E")]
			public override string get_PrimaryKey() { }

			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000206")]
			public override string get_ProviderId() { }

			[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000210")]
			public override Type get_ResourceType() { }

			[Address(RVA = "0x27B14E0", Offset = "0x27B08E0", Length = "0x5D")]
			[Token(Token = "0x6000213")]
			public override int Hash(Type resultType) { }

			[Address(RVA = "0x27B1540", Offset = "0x27B0940", Length = "0x11D")]
			[Token(Token = "0x6000208")]
			private static void ProcDependencies(ResourceLocation l, ResourceLocation d, int i, int count) { }

			[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x600020D")]
			internal void set_Data(object value) { }

			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000205")]
			internal void set_InternalId(string value) { }

			[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x600020F")]
			internal void set_PrimaryKey(string value) { }

			[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000207")]
			internal void set_ProviderId(string value) { }

			[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000211")]
			internal void set_ResourceType(Type value) { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6000212")]
			public virtual string ToString() { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000111")]
		private Dictionary<Object, UInt32> keyData; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000112")]
		private Reader reader; //Field offset: 0x18
		[CompilerGenerated]
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000113")]
		private string <LocatorId>k__BackingField; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000114")]
		private string providerSuffix; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000115")]
		private LocateProcContext sharedContext; //Field offset: 0x30

		[Token(Token = "0x17000048")]
		public override IEnumerable<IResourceLocation> AllLocations
		{
			[Address(RVA = "0x27B22C0", Offset = "0x27B16C0", Length = "0x329")]
			[Token(Token = "0x60001FE")]
			 get { } //Length: 809
		}

		[Token(Token = "0x17000047")]
		public override IEnumerable<Object> Keys
		{
			[Address(RVA = "0x27B25F0", Offset = "0x27B19F0", Length = "0x44")]
			[Token(Token = "0x60001FD")]
			 get { } //Length: 68
		}

		[Token(Token = "0x17000046")]
		public private override string LocatorId
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60001FB")]
			 get { } //Length: 5
			[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60001FC")]
			private set { } //Length: 13
		}

		[Address(RVA = "0x27B2090", Offset = "0x27B1490", Length = "0x222")]
		[Token(Token = "0x60001FF")]
		internal ResourceLocator(string id, Reader reader, string providerSuffix) { }

		[Address(RVA = "0x27B22C0", Offset = "0x27B16C0", Length = "0x329")]
		[Token(Token = "0x60001FE")]
		public override IEnumerable<IResourceLocation> get_AllLocations() { }

		[Address(RVA = "0x27B25F0", Offset = "0x27B19F0", Length = "0x44")]
		[Token(Token = "0x60001FD")]
		public override IEnumerable<Object> get_Keys() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001FB")]
		public override string get_LocatorId() { }

		[Address(RVA = "0x27B1B70", Offset = "0x27B0F70", Length = "0x3AA")]
		[Token(Token = "0x6000201")]
		public override bool Locate(object key, Type type, out IList<IResourceLocation>& locations) { }

		[Address(RVA = "0x27B1F20", Offset = "0x27B1320", Length = "0x16D")]
		[Token(Token = "0x6000200")]
		private static void ProcFunc(ResourceLocation loc, LocateProcContext context, int i, int count) { }

		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001FC")]
		private void set_LocatorId(string value) { }

	}

	[Token(Token = "0x200004A")]
	public class Serializer : ISerializationAdapter<ContentCatalogData>, ISerializationAdapter
	{
		[CompilerGenerated]
		[Token(Token = "0x200004B")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400010F")]
			public UInt32[] locationIds; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000110")]
			public Func<Int32, UInt32> <>9__0; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60001F9")]
			public <>c__DisplayClass5_0() { }

			[Address(RVA = "0x27B5620", Offset = "0x27B4A20", Length = "0x2B")]
			[Token(Token = "0x60001FA")]
			internal uint <Serialize>b__0(int i) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400010E")]
		private bool resolveInternalIds; //Field offset: 0x10

		[Token(Token = "0x17000045")]
		public override IEnumerable<ISerializationAdapter> Dependencies
		{
			[Address(RVA = "0x27B4760", Offset = "0x27B3B60", Length = "0x1A7")]
			[Token(Token = "0x60001F4")]
			 get { } //Length: 423
		}

		[Address(RVA = "0x27B4750", Offset = "0x27B3B50", Length = "0xB")]
		[Token(Token = "0x60001F8")]
		public Serializer() { }

		[Address(RVA = "0x27B3340", Offset = "0x27B2740", Length = "0x335")]
		[Token(Token = "0x60001F6")]
		public override object Deserialize(Reader reader, Type t, uint offset, out uint size) { }

		[Address(RVA = "0x27B4760", Offset = "0x27B3B60", Length = "0x1A7")]
		[Token(Token = "0x60001F4")]
		public override IEnumerable<ISerializationAdapter> get_Dependencies() { }

		[Address(RVA = "0x27B3D10", Offset = "0x27B3110", Length = "0xA28")]
		[Token(Token = "0x60001F7")]
		public override uint Serialize(Writer writer, object val) { }

		[Address(RVA = "0x27B4740", Offset = "0x27B3B40", Length = "0x8")]
		[Token(Token = "0x60001F5")]
		public Serializer WithInternalIdResolvingDisabled() { }

	}

	[Token(Token = "0x4000103")]
	private static int kMagic; //Field offset: 0x0
	[Token(Token = "0x4000104")]
	private const int kVersion = 2; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000105")]
	public string LocalHash; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000106")]
	internal IResourceLocation location; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000107")]
	internal string m_LocatorId; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000108")]
	internal string m_BuildResultHash; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000109")]
	private ObjectInitializationData m_InstanceProviderData; //Field offset: 0x30
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400010A")]
	private ObjectInitializationData m_SceneProviderData; //Field offset: 0x60
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x400010B")]
	internal List<ObjectInitializationData> m_ResourceProviderData; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400010C")]
	private IList<ContentCatalogDataEntry> m_Entries; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400010D")]
	private Reader m_Reader; //Field offset: 0xA0

	[Token(Token = "0x17000040")]
	public string BuildResultHash
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60001E1")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60001E2")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000042")]
	public ObjectInitializationData InstanceProviderData
	{
		[Address(RVA = "0x27A9020", Offset = "0x27A8420", Length = "0x1B")]
		[Token(Token = "0x60001E5")]
		 get { } //Length: 27
		[Address(RVA = "0x27A9060", Offset = "0x27A8460", Length = "0x22")]
		[Token(Token = "0x60001E6")]
		 set { } //Length: 34
	}

	[Token(Token = "0x17000041")]
	public internal string ProviderId
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60001E3")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60001E4")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000044")]
	public List<ObjectInitializationData> ResourceProviderData
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x60001E9")]
		 get { } //Length: 8
		[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
		[Token(Token = "0x60001EA")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000043")]
	public ObjectInitializationData SceneProviderData
	{
		[Address(RVA = "0x27A9040", Offset = "0x27A8440", Length = "0x1E")]
		[Token(Token = "0x60001E7")]
		 get { } //Length: 30
		[Address(RVA = "0x27A9090", Offset = "0x27A8490", Length = "0x25")]
		[Token(Token = "0x60001E8")]
		 set { } //Length: 37
	}

	[Address(RVA = "0x27A8DF0", Offset = "0x27A81F0", Length = "0x65")]
	[Token(Token = "0x60001F3")]
	private static ContentCatalogData() { }

	[Address(RVA = "0x27A8F80", Offset = "0x27A8380", Length = "0xA0")]
	[Token(Token = "0x60001EF")]
	internal ContentCatalogData(Reader reader) { }

	[Address(RVA = "0x27A8F00", Offset = "0x27A8300", Length = "0x7D")]
	[Token(Token = "0x60001EC")]
	public ContentCatalogData() { }

	[Address(RVA = "0x27A8E60", Offset = "0x27A8260", Length = "0x9A")]
	[Token(Token = "0x60001EB")]
	public ContentCatalogData(string id) { }

	[Address(RVA = "0x27A8B50", Offset = "0x27A7F50", Length = "0x3A")]
	[Token(Token = "0x60001ED")]
	internal void CleanData() { }

	[Address(RVA = "0x27A8B90", Offset = "0x27A7F90", Length = "0x2B")]
	[Token(Token = "0x60001EE")]
	internal void CopyToFile(string path) { }

	[Address(RVA = "0x27A8BC0", Offset = "0x27A7FC0", Length = "0x95")]
	[Token(Token = "0x60001F1")]
	internal IResourceLocator CreateCustomLocator(string overrideId = "", string providerSuffix = null) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60001E1")]
	public string get_BuildResultHash() { }

	[Address(RVA = "0x27A9020", Offset = "0x27A8420", Length = "0x1B")]
	[Token(Token = "0x60001E5")]
	public ObjectInitializationData get_InstanceProviderData() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60001E3")]
	public string get_ProviderId() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x60001E9")]
	public List<ObjectInitializationData> get_ResourceProviderData() { }

	[Address(RVA = "0x27A9040", Offset = "0x27A8440", Length = "0x1E")]
	[Token(Token = "0x60001E7")]
	public ObjectInitializationData get_SceneProviderData() { }

	[Address(RVA = "0x27A8C60", Offset = "0x27A8060", Length = "0x1E")]
	[Token(Token = "0x60001F0")]
	internal Byte[] GetBytes() { }

	[Address(RVA = "0x27A8C80", Offset = "0x27A8080", Length = "0x165")]
	[Token(Token = "0x60001F2")]
	internal static ContentCatalogData LoadFromFile(string path, bool resolveInternalIds) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x60001E2")]
	public void set_BuildResultHash(string value) { }

	[Address(RVA = "0x27A9060", Offset = "0x27A8460", Length = "0x22")]
	[Token(Token = "0x60001E6")]
	public void set_InstanceProviderData(ObjectInitializationData value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60001E4")]
	internal void set_ProviderId(string value) { }

	[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
	[Token(Token = "0x60001EA")]
	public void set_ResourceProviderData(List<ObjectInitializationData> value) { }

	[Address(RVA = "0x27A9090", Offset = "0x27A8490", Length = "0x25")]
	[Token(Token = "0x60001E8")]
	public void set_SceneProviderData(ObjectInitializationData value) { }

}

