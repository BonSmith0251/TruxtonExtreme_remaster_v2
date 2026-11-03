namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x200023E")]
public class RenderGraph
{
	[CompilerGenerated]
	[Token(Token = "0x2000257")]
	private sealed class <>c
	{
		[Token(Token = "0x4000AB4")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000AB5")]
		public static BaseRenderFunc<ProfilingScopePassData, UnsafeGraphContext> <>9__133_0; //Field offset: 0x8
		[Token(Token = "0x4000AB6")]
		public static BaseRenderFunc<ProfilingScopePassData, UnsafeGraphContext> <>9__134_0; //Field offset: 0x10

		[Address(RVA = "0x2C889A0", Offset = "0x2C87DA0", Length = "0x67")]
		[Token(Token = "0x60010A6")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60010A7")]
		public <>c() { }

		[Address(RVA = "0x2C885E0", Offset = "0x2C879E0", Length = "0x7B")]
		[Token(Token = "0x60010A8")]
		internal void <BeginProfilingSampler>b__133_0(ProfilingScopePassData data, UnsafeGraphContext ctx) { }

		[Address(RVA = "0x2C886D0", Offset = "0x2C87AD0", Length = "0x7B")]
		[Token(Token = "0x60010A9")]
		internal void <EndProfilingSampler>b__134_0(ProfilingScopePassData data, UnsafeGraphContext ctx) { }

	}

	[Token(Token = "0x2000252")]
	public class CompiledGraph : ICompiledGraph
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A88")]
		public DynamicArray<CompiledResourceInfo>[] compiledResourcesInfos; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A89")]
		public DynamicArray<CompiledPassInfo> compiledPassInfos; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A8A")]
		public int lastExecutionFrame; //Field offset: 0x20

		[Address(RVA = "0x2C6EDC0", Offset = "0x2C6E1C0", Length = "0x16D")]
		[Token(Token = "0x600108D")]
		public CompiledGraph() { }

		[Address(RVA = "0x2C6E9D0", Offset = "0x2C6DDD0", Length = "0x9F")]
		[Token(Token = "0x600108E")]
		public override void Clear() { }

		[Address(RVA = "0x2C6EC00", Offset = "0x2C6E000", Length = "0x1BF")]
		[Token(Token = "0x6001090")]
		public void InitializeCompilationData(List<RenderGraphPass> passes, RenderGraphResourceRegistry resources) { }

		[Address(RVA = "0x2C6EA70", Offset = "0x2C6DE70", Length = "0x185")]
		[Token(Token = "0x600108F")]
		private void InitResourceInfosData(DynamicArray<CompiledResourceInfo> resourceInfos, int count) { }

	}

	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	[Token(Token = "0x2000250")]
	public struct CompiledPassInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A76")]
		public string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A77")]
		public int index; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A78")]
		public List<Int32>[] resourceCreateList; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A79")]
		public List<Int32>[] resourceReleaseList; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A7A")]
		public GraphicsFence fence; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A7B")]
		public int refCount; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000A7C")]
		public int syncToPassIndex; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000A7D")]
		public int syncFromPassIndex; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000A7E")]
		public bool enableAsyncCompute; //Field offset: 0x3C
		[FieldOffset(Offset = "0x3D")]
		[Token(Token = "0x4000A7F")]
		public bool allowPassCulling; //Field offset: 0x3D
		[FieldOffset(Offset = "0x3E")]
		[Token(Token = "0x4000A80")]
		public bool needGraphicsFence; //Field offset: 0x3E
		[FieldOffset(Offset = "0x3F")]
		[Token(Token = "0x4000A81")]
		public bool culled; //Field offset: 0x3F
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000A82")]
		public bool culledByRendererList; //Field offset: 0x40
		[FieldOffset(Offset = "0x41")]
		[Token(Token = "0x4000A83")]
		public bool hasSideEffect; //Field offset: 0x41
		[FieldOffset(Offset = "0x42")]
		[Token(Token = "0x4000A84")]
		public bool enableFoveatedRasterization; //Field offset: 0x42
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000A85")]
		public ExtendedFeatureFlags extendedFeatureFlags; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000A86")]
		public bool hasShadingRateImage; //Field offset: 0x48
		[FieldOffset(Offset = "0x49")]
		[Token(Token = "0x4000A87")]
		public bool hasShadingRateStates; //Field offset: 0x49

		[Address(RVA = "0x2C6EF30", Offset = "0x2C6E330", Length = "0x2AF")]
		[Token(Token = "0x600108B")]
		public void Reset(RenderGraphPass pass, int index) { }

	}

	[Token(Token = "0x200024F")]
	public struct CompiledResourceInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A72")]
		public List<Int32> producers; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A73")]
		public List<Int32> consumers; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A74")]
		public int refCount; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000A75")]
		public bool imported; //Field offset: 0x14

		[Address(RVA = "0x2C6F1E0", Offset = "0x2C6E5E0", Length = "0xDE")]
		[Token(Token = "0x600108A")]
		public void Reset() { }

	}

	[Token(Token = "0x2000240")]
	public class DebugData
	{
		[Token(Token = "0x200024A")]
		internal class BufferResourceData
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000A5C")]
			public int count; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4000A5D")]
			public int stride; //Field offset: 0x14
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000A5E")]
			public Target target; //Field offset: 0x18
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4000A5F")]
			public UsageFlags usage; //Field offset: 0x1C

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6001086")]
			public BufferResourceData() { }

		}

		[DebuggerDisplay("PassDebug: {name}")]
		[Token(Token = "0x2000244")]
		internal struct PassData
		{
			[Token(Token = "0x2000246")]
			internal class NRPInfo
			{
				[Token(Token = "0x2000247")]
				internal class NativeRenderPassInfo
				{
					[Token(Token = "0x2000248")]
					internal class AttachmentInfo
					{
						[FieldOffset(Offset = "0x10")]
						[Token(Token = "0x4000A54")]
						public string resourceName; //Field offset: 0x10
						[FieldOffset(Offset = "0x18")]
						[Token(Token = "0x4000A55")]
						public string loadReason; //Field offset: 0x18
						[FieldOffset(Offset = "0x20")]
						[Token(Token = "0x4000A56")]
						public string storeReason; //Field offset: 0x20
						[FieldOffset(Offset = "0x28")]
						[Token(Token = "0x4000A57")]
						public string storeMsaaReason; //Field offset: 0x28
						[FieldOffset(Offset = "0x30")]
						[Token(Token = "0x4000A58")]
						public int attachmentIndex; //Field offset: 0x30
						[FieldOffset(Offset = "0x38")]
						[Token(Token = "0x4000A59")]
						public SerializableNativePassAttachment attachment; //Field offset: 0x38

						[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
						[Token(Token = "0x6001085")]
						public AttachmentInfo() { }

					}

					[Token(Token = "0x2000249")]
					internal struct PassCompatibilityInfo
					{
						[FieldOffset(Offset = "0x0")]
						[Token(Token = "0x4000A5A")]
						public string message; //Field offset: 0x0
						[FieldOffset(Offset = "0x8")]
						[Token(Token = "0x4000A5B")]
						public bool isCompatible; //Field offset: 0x8

					}

					[FieldOffset(Offset = "0x10")]
					[Token(Token = "0x4000A50")]
					public string passBreakReasoning; //Field offset: 0x10
					[FieldOffset(Offset = "0x18")]
					[Token(Token = "0x4000A51")]
					public List<AttachmentInfo> attachmentInfos; //Field offset: 0x18
					[FieldOffset(Offset = "0x20")]
					[Token(Token = "0x4000A52")]
					public SerializedDictionary<Int32, PassCompatibilityInfo> passCompatibility; //Field offset: 0x20
					[FieldOffset(Offset = "0x28")]
					[Token(Token = "0x4000A53")]
					public List<Int32> mergedPassIds; //Field offset: 0x28

					[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
					[Token(Token = "0x6001084")]
					public NativeRenderPassInfo() { }

				}

				[FieldOffset(Offset = "0x10")]
				[SerializeReference]
				[Token(Token = "0x4000A48")]
				public NativeRenderPassInfo nativePassInfo; //Field offset: 0x10
				[FieldOffset(Offset = "0x18")]
				[Token(Token = "0x4000A49")]
				public List<Int32> textureFBFetchList; //Field offset: 0x18
				[FieldOffset(Offset = "0x20")]
				[Token(Token = "0x4000A4A")]
				public List<Int32> setGlobals; //Field offset: 0x20
				[FieldOffset(Offset = "0x28")]
				[Token(Token = "0x4000A4B")]
				public int width; //Field offset: 0x28
				[FieldOffset(Offset = "0x2C")]
				[Token(Token = "0x4000A4C")]
				public int height; //Field offset: 0x2C
				[FieldOffset(Offset = "0x30")]
				[Token(Token = "0x4000A4D")]
				public int volumeDepth; //Field offset: 0x30
				[FieldOffset(Offset = "0x34")]
				[Token(Token = "0x4000A4E")]
				public int samples; //Field offset: 0x34
				[FieldOffset(Offset = "0x38")]
				[Token(Token = "0x4000A4F")]
				public bool hasDepth; //Field offset: 0x38

				[Address(RVA = "0x2C71970", Offset = "0x2C70D70", Length = "0xA5")]
				[Token(Token = "0x6001083")]
				public NRPInfo() { }

			}

			[Token(Token = "0x2000245")]
			internal class ResourceIdLists : ResourceLists<Int32>
			{

				[Address(RVA = "0x2C87E40", Offset = "0x2C87240", Length = "0x39")]
				[Token(Token = "0x6001082")]
				public ResourceIdLists() { }

			}

			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000A3C")]
			public string name; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000A3D")]
			public RenderGraphPassType type; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000A3E")]
			public ResourceIdLists resourceReadLists; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000A3F")]
			public ResourceIdLists resourceWriteLists; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000A40")]
			public bool culled; //Field offset: 0x20
			[FieldOffset(Offset = "0x21")]
			[Token(Token = "0x4000A41")]
			public bool async; //Field offset: 0x21
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x4000A42")]
			public int nativeSubPassIndex; //Field offset: 0x24
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000A43")]
			public int syncToPassIndex; //Field offset: 0x28
			[FieldOffset(Offset = "0x2C")]
			[Token(Token = "0x4000A44")]
			public int syncFromPassIndex; //Field offset: 0x2C
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4000A45")]
			public bool generateDebugData; //Field offset: 0x30
			[FieldOffset(Offset = "0x38")]
			[SerializeReference]
			[Token(Token = "0x4000A46")]
			public NRPInfo nrpInfo; //Field offset: 0x38
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x4000A47")]
			public PassScriptInfo scriptInfo; //Field offset: 0x40

		}

		[Token(Token = "0x200024D")]
		internal struct PassScriptInfo
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000A70")]
			public string filePath; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000A71")]
			public int line; //Field offset: 0x8

		}

		[DebuggerDisplay("ResourceDebug: {name} [{creationPassIndex}:{releasePassIndex}]")]
		[Token(Token = "0x200024C")]
		internal struct ResourceData
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000A67")]
			public string name; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000A68")]
			public bool imported; //Field offset: 0x8
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x4000A69")]
			public int creationPassIndex; //Field offset: 0xC
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000A6A")]
			public int releasePassIndex; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000A6B")]
			public List<Int32> consumerList; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000A6C")]
			public List<Int32> producerList; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000A6D")]
			public bool memoryless; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[SerializeReference]
			[Token(Token = "0x4000A6E")]
			public TextureResourceData textureData; //Field offset: 0x30
			[FieldOffset(Offset = "0x38")]
			[SerializeReference]
			[Token(Token = "0x4000A6F")]
			public BufferResourceData bufferData; //Field offset: 0x38

		}

		[Token(Token = "0x2000242")]
		internal class ResourceDataLists : ResourceLists<ResourceData>
		{

			[Address(RVA = "0x2C87E00", Offset = "0x2C87200", Length = "0x39")]
			[Token(Token = "0x6001080")]
			public ResourceDataLists() { }

		}

		[DefaultMember("Item")]
		[Token(Token = "0x2000241")]
		internal class ResourceLists
		{
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			[Token(Token = "0x4000A34")]
			private List<T> m_Textures; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			[Token(Token = "0x4000A35")]
			private List<T> m_Buffers; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			[Token(Token = "0x4000A36")]
			private List<T> m_AccelerationStructures; //Field offset: 0x0

			[Token(Token = "0x1700021F")]
			public List<T> Item
			{
				[Address(RVA = "0xF538C0", Offset = "0xF52CC0", Length = "0x7B")]
				[Token(Token = "0x600107C")]
				 get { } //Length: 123
				[Address(RVA = "0xF53940", Offset = "0xF52D40", Length = "0x18D")]
				[Token(Token = "0x600107D")]
				 set { } //Length: 397
			}

			[Address(RVA = "0xF53660", Offset = "0xF52A60", Length = "0x124")]
			[Token(Token = "0x600107F")]
			public ResourceLists`1() { }

			[Address(RVA = "0xF532C0", Offset = "0xF526C0", Length = "0x29D")]
			[Token(Token = "0x600107E")]
			public void Clear() { }

			[Address(RVA = "0xF538C0", Offset = "0xF52CC0", Length = "0x7B")]
			[Token(Token = "0x600107C")]
			public List<T> get_Item(int index) { }

			[Address(RVA = "0xF53940", Offset = "0xF52D40", Length = "0x18D")]
			[Token(Token = "0x600107D")]
			public void set_Item(int index, List<T> value) { }

		}

		[Token(Token = "0x2000243")]
		internal class SerializableNativePassAttachment
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000A37")]
			public RenderBufferLoadAction loadAction; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4000A38")]
			public RenderBufferStoreAction storeAction; //Field offset: 0x14
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000A39")]
			public bool memoryless; //Field offset: 0x18
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4000A3A")]
			public int mipLevel; //Field offset: 0x1C
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000A3B")]
			public int depthSlice; //Field offset: 0x20

			[Address(RVA = "0x2C88130", Offset = "0x2C87530", Length = "0x41")]
			[Token(Token = "0x6001081")]
			public SerializableNativePassAttachment(NativePassAttachment att) { }

		}

		[Token(Token = "0x200024B")]
		internal class TextureResourceData
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000A60")]
			public int width; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4000A61")]
			public int height; //Field offset: 0x14
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000A62")]
			public int depth; //Field offset: 0x18
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4000A63")]
			public bool bindMS; //Field offset: 0x1C
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000A64")]
			public int samples; //Field offset: 0x20
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x4000A65")]
			public GraphicsFormat format; //Field offset: 0x24
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000A66")]
			public bool clearBuffer; //Field offset: 0x28

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6001087")]
			public TextureResourceData() { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A2E")]
		public string executionName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A2F")]
		public bool valid; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000A30")]
		public int graphHash; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A31")]
		public bool isNRPCompiler; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A32")]
		public List<PassData> passList; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A33")]
		public ResourceDataLists resourceLists; //Field offset: 0x30

		[Address(RVA = "0x2C705D0", Offset = "0x2C6F9D0", Length = "0xEA")]
		[Token(Token = "0x600107A")]
		public DebugData(string executionName) { }

		[Address(RVA = "0x2C70550", Offset = "0x2C6F950", Length = "0x7F")]
		[Token(Token = "0x600107B")]
		public void Clear() { }

	}

	[Token(Token = "0x200024E")]
	public static class DebugDataSerialization
	{

		[Address(RVA = "0x2C704D0", Offset = "0x2C6F8D0", Length = "0x4F")]
		[Token(Token = "0x6001089")]
		public static DebugData FromJson(string json) { }

		[Address(RVA = "0x2C70520", Offset = "0x2C6F920", Length = "0x21")]
		[Token(Token = "0x6001088")]
		public static string ToJson(DebugData debugData) { }

	}

	[Token(Token = "0x200023F")]
	public class DebugExecutionItem
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A2C")]
		private readonly EntityId <id>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A2D")]
		private readonly string <name>k__BackingField; //Field offset: 0x18

		[Token(Token = "0x1700021D")]
		public EntityId id
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[CompilerGenerated]
			[Token(Token = "0x6001077")]
			 get { } //Length: 85
		}

		[Token(Token = "0x1700021E")]
		public string name
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001078")]
			 get { } //Length: 5
		}

		[Address(RVA = "0xF53D70", Offset = "0xF53170", Length = "0x40")]
		[Token(Token = "0x6001079")]
		public DebugExecutionItem(EntityId id, string name) { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6001077")]
		public EntityId get_id() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001078")]
		public string get_name() { }

	}

	[Token(Token = "0x2000251")]
	public interface ICompiledGraph
	{

		[Token(Token = "0x600108C")]
		public void Clear() { }

	}

	[Token(Token = "0x2000255")]
	public sealed class OnExecutionRegisteredDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2C71AC0", Offset = "0x2C70EC0", Length = "0xB5")]
		[Token(Token = "0x6001096")]
		public OnExecutionRegisteredDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x2C71A20", Offset = "0x2C70E20", Length = "0x92")]
		[Token(Token = "0x6001098")]
		public override IAsyncResult BeginInvoke(string graphName, EntityId executionId, string executionName, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6001099")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x6001097")]
		public override void Invoke(string graphName, EntityId executionId, string executionName) { }

	}

	[Token(Token = "0x2000254")]
	public sealed class OnGraphRegisteredDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1FCA570", Offset = "0x1FC9970", Length = "0xB4")]
		[Token(Token = "0x6001092")]
		public OnGraphRegisteredDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x6001094")]
		public override IAsyncResult BeginInvoke(string graphName, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6001095")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6001093")]
		public override void Invoke(string graphName) { }

	}

	[Token(Token = "0x2000253")]
	private class ProfilingScopePassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A8B")]
		public ProfilingSampler sampler; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001091")]
		public ProfilingScopePassData() { }

	}

	[Token(Token = "0x2000256")]
	public static class RenderGraphExceptionMessages
	{
		[Token(Token = "0x4000A8C")]
		internal static bool enableCaller; //Field offset: 0x0
		[Token(Token = "0x4000AA2")]
		internal const string k_MoreThanOneTextureForFragInputIndex = "You can only bind a single texture to a fragment input index. Verify your indexes are correct."; //Field offset: 0x0
		[Token(Token = "0x4000AA3")]
		internal const string k_MoreThanOneTextureRandomWriteInputIndex = "You can only bind a single texture to a random write input index. Verify your indexes are correct."; //Field offset: 0x0
		[Token(Token = "0x4000AA4")]
		internal const string k_MultipleDepthTextures = "You can only set a single depth texture per pass."; //Field offset: 0x0
		[Token(Token = "0x4000AA5")]
		internal const string k_LoadingMemorylessResource = "This pass is loading a resource marked as memoryless."; //Field offset: 0x0
		[Token(Token = "0x4000AA6")]
		internal const string k_ResolvignMemorylessResource = "This pass is storing or resolving a resource marked as memoryless"; //Field offset: 0x0
		[Token(Token = "0x4000AA7")]
		internal const string k_RenderPassIsEmpty = "Empty render pass"; //Field offset: 0x0
		[Token(Token = "0x4000AA8")]
		internal const string k_RenderPassHasInvalidProperties = "Invalid render pass properties. One or more properties are zero."; //Field offset: 0x0
		[Token(Token = "0x4000AA1")]
		internal const string k_MoreThanOneResourceForMRTIndex = "You can only bind a single texture to a single index in a multiple render texture (MRT). Verify your indexes are correct."; //Field offset: 0x0
		[Token(Token = "0x4000AA9")]
		internal const string k_ShadingRateImageAttachmentDoesNotMatch = "Low level rendergraph error: Shading rate image attachment in renderpass does not match."; //Field offset: 0x0
		[Token(Token = "0x4000AAB")]
		internal const string k_MultisampledShaderResolveInvalidAttachmentSetup = "Low level rendergraph error: last subpass with shader resolve must have one color attachment."; //Field offset: 0x0
		[Token(Token = "0x4000AAC")]
		internal const string k_MultisampledShaderResolveInputAttachmentNotMemoryless = "Low level rendergraph error: last subpass with shader resolve must have all input attachments as memoryless attachments."; //Field offset: 0x0
		[Token(Token = "0x4000AAD")]
		internal const string k_InvalidMRTSetup = "Multiple render texture (MRT) setup is invalid. Some indices are not used."; //Field offset: 0x0
		[Token(Token = "0x4000AAE")]
		internal const string k_NoDepthBufferMRT = "Setting multiple render textures (MRTs) without a depth buffer is not supported."; //Field offset: 0x0
		[Token(Token = "0x4000AAF")]
		internal const string k_InvalidDepthAndColorTargets = "Neither depth nor color render targets are correctly set up."; //Field offset: 0x0
		[Token(Token = "0x4000AB0")]
		internal const string k_InvalidResourceType = "Invalid resource type, expected texture or buffer"; //Field offset: 0x0
		[Token(Token = "0x4000AB1")]
		internal const string k_NoRenderFunction = "RenderPass was not provided with an execute function."; //Field offset: 0x0
		[Token(Token = "0x4000AAA")]
		internal const string k_AttachmentsDoNotMatch = "Low level rendergraph error: Attachments in renderpass do not match."; //Field offset: 0x0
		[Token(Token = "0x4000AA0")]
		internal const string k_ReadWriteTransient = "This pass is reading or writing a transient resource. Transient resources are always assumed to be both read and written using 'AccessFlags.ReadWrite'."; //Field offset: 0x0
		[Token(Token = "0x4000A9F")]
		internal const string k_InvalidResource = "Using an invalid resource. Invalid resources can be resources leftover from a previous execution."; //Field offset: 0x0
		[Token(Token = "0x4000A9E")]
		internal const string k_SetRenderAttachmentOnGlobalTexture = "SetRenderAttachment is called on a texture that is currently bound to a global texture slot. Shaders might be using the texture using samplers. Make sure textures are not set as globals when using them as fragment attachments."; //Field offset: 0x0
		[Token(Token = "0x4000A8D")]
		internal const string k_RenderGraphExecutionError = "Render Graph Execution error"; //Field offset: 0x0
		[Token(Token = "0x4000A8F")]
		private const string k_ErrorDefaultMessage = "Invalid render graph state, impossible to log the exception."; //Field offset: 0x0
		[Token(Token = "0x4000A90")]
		internal const string k_NonTextureAsAttachmentError = "Only textures can be used as a fragment attachment."; //Field offset: 0x0
		[Token(Token = "0x4000A91")]
		internal const string k_OneResourceTwoVersionsError = "A pass is using SetAttachment or UseTexture on two versions of the same resource. Make sure you only access the latest version."; //Field offset: 0x0
		[Token(Token = "0x4000A92")]
		internal const string k_UseTextureRandWriteTwoVersionsError = "A pass is using UseTextureRandomWrite on two versions of the same resource.  Make sure you only access the latest version."; //Field offset: 0x0
		[Token(Token = "0x4000A93")]
		internal const string k_InvalidGetRenderTargetInfoResultsError = "GetRenderTargetInfo returned invalid results. Check that the width, height, and number of MSAA samples is not 0."; //Field offset: 0x0
		[Token(Token = "0x4000A94")]
		internal const string k_CannotDetermineSubPassFlagNoDepth = "SubPassFlag for merging cannot be determined if native pass doesn't have a depth attachment. Make sure your pass has a depth attachment."; //Field offset: 0x0
		[Token(Token = "0x4000AB2")]
		internal const string k_BeginNoActivePass = "Compiler error: Pass is marked as beginning a native sub pass but no pass is currently active."; //Field offset: 0x0
		[Token(Token = "0x4000A95")]
		internal const string k_AddingOlderAttachmentVersion = "The pass adds an older version while a higher version is already registered with the pass. Make sure you only access the latest version."; //Field offset: 0x0
		[Token(Token = "0x4000A97")]
		internal const string k_NonIncrementalDestructionCall = "Something went wrong when compiling the graph. The Destruction lists must be set-up incrementally for all passes, AddLastUse is called in an arbitrary non-incremental way."; //Field offset: 0x0
		[Token(Token = "0x4000A98")]
		internal const string k_UndisposedBuilderPreviousPass = "Finish building the previous pass first by disposing of the pass builder object before adding a new pass. You can manually dispose of the builder with 'builder.Dispose()'."; //Field offset: 0x0
		[Token(Token = "0x4000A99")]
		internal const string k_WriteToVersionedResource = "The pass writes to a versioned resource handle. You can only write to unversioned resource handles to avoid branches in the resource history."; //Field offset: 0x0
		[Token(Token = "0x4000A9A")]
		internal const string k_WriteToResourceTwice = "The pass writes to a resource twice. You can only write the same resource once within a pass."; //Field offset: 0x0
		[Token(Token = "0x4000A9B")]
		internal const string k_TextureAlreadyBeingUsedThroughSetAttachment = "UseTexture is called on a texture that is already used through SetRenderAttachment. Check your code and make sure the texture is only used once."; //Field offset: 0x0
		[Token(Token = "0x4000A9C")]
		internal const string k_SetRenderAttachmentTextureAlreadyUsed = "SetRenderAttachment is called on a texture that is already used through UseTexture/SetRenderAttachment. Check your code and make sure the texture is only used once."; //Field offset: 0x0
		[Token(Token = "0x4000A9D")]
		internal const string k_SetRenderAttachmentOnDepthTexture = "SetRenderAttachment is called on a texture that has a depth format. Use a texture with a color format instead, or call SetRenderDepthAttachment."; //Field offset: 0x0
		[Token(Token = "0x4000A96")]
		internal const string k_NonIncrementalCreationCall = "Something went wrong when compiling the graph. The Creation lists must be set-up incrementally for all passes, but AddFirstUse is called in an arbitrary non-incremental way."; //Field offset: 0x0
		[Token(Token = "0x4000AB3")]
		internal const string k_NoActivePassForSubpass = "Compiler error: Generated a subpass pass but no pass is currently active."; //Field offset: 0x0
		[Token(Token = "0x4000A8E")]
		private static readonly Dictionary<RenderGraphState, String> m_RenderGraphStateMessages; //Field offset: 0x8

		[Address(RVA = "0x2C7B350", Offset = "0x2C7A750", Length = "0x177")]
		[Token(Token = "0x60010A5")]
		private static RenderGraphExceptionMessages() { }

		[Address(RVA = "0x2C7A510", Offset = "0x2C79910", Length = "0x24A")]
		[Token(Token = "0x60010A3")]
		internal static string GetExceptionMessage(RenderGraphState state) { }

		[Address(RVA = "0x2C7A760", Offset = "0x2C79B60", Length = "0xD7")]
		[Token(Token = "0x60010A4")]
		private static string GetHigherCaller() { }

		[Address(RVA = "0x2C7AAC0", Offset = "0x2C79EC0", Length = "0x2BD")]
		[Token(Token = "0x600109F")]
		internal static string IncompatibleTextureUVOrigin(TextureUVOriginSelection origin, string attachmentType, string attachmentName, RenderGraphResourceType attachmentResourceType, int attachmentResourceIndex, TextureUVOriginSelection attachmentOrigin) { }

		[Address(RVA = "0x2C7A840", Offset = "0x2C79C40", Length = "0x1E3")]
		[Token(Token = "0x60010A2")]
		internal static string IncompatibleTextureUVOriginStore(string firstAttachmentName, TextureUVOriginSelection firstAttachmentOrigin, string secondAttachmentName, TextureUVOriginSelection secondAttachmentOrigin) { }

		[Address(RVA = "0x2C7AA30", Offset = "0x2C79E30", Length = "0x88")]
		[Token(Token = "0x60010A0")]
		internal static string IncompatibleTextureUVOriginUseTexture(TextureUVOriginSelection origin) { }

		[Address(RVA = "0x2C7AD80", Offset = "0x2C7A180", Length = "0x2A2")]
		[Token(Token = "0x600109A")]
		internal static string MismatchInDimensions(string name, int fragWidth, int fragHeight, int fragVolumeDepth, ResourceUnversionedData resInfo) { }

		[Address(RVA = "0x2C7B030", Offset = "0x2C7A430", Length = "0x1AE")]
		[Token(Token = "0x600109B")]
		internal static string MismatchInMSAASamlpes(string name, int expectedSamples, int actualSamples) { }

		[Address(RVA = "0x2C7B1E0", Offset = "0x2C7A5E0", Length = "0x51")]
		[Token(Token = "0x600109C")]
		internal static string NoGlobalTextureAtPropertyID(int propertyId) { }

		[Address(RVA = "0x2C7B240", Offset = "0x2C7A640", Length = "0x5D")]
		[Token(Token = "0x600109D")]
		internal static string UseDepthWithColorFormat(GraphicsFormat colorFormat) { }

		[Address(RVA = "0x2C7B2A0", Offset = "0x2C7A6A0", Length = "0x51")]
		[Token(Token = "0x600109E")]
		internal static string UseTransientTextureInWrongPass(int transientIndex) { }

		[Address(RVA = "0x2C7B300", Offset = "0x2C7A700", Length = "0x4F")]
		[Token(Token = "0x60010A1")]
		internal static string UsingLegacyRenderGraph(string passName) { }

	}

	[Token(Token = "0x4000A04")]
	public static readonly int kMaxMRTCount; //Field offset: 0x0
	[Token(Token = "0x4000A25")]
	private const string k_BeginProfilingSamplerPassName = "BeginProfile"; //Field offset: 0x0
	[Token(Token = "0x4000A26")]
	private const string k_EndProfilingSamplerPassName = "EndProfile"; //Field offset: 0x0
	[Token(Token = "0x4000A1D")]
	internal static Nullable<Boolean> s_EnableCompilationCachingForTests; //Field offset: 0x4
	[Token(Token = "0x4000A22")]
	private static Dictionary<RenderGraph, List`1<DebugExecutionItem>> s_RegisteredExecutions; //Field offset: 0x8
	[CompilerGenerated]
	[Token(Token = "0x4000A24")]
	private static bool <enableValidityChecks>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[Token(Token = "0x4000A27")]
	private static OnGraphRegisteredDelegate onGraphRegistered; //Field offset: 0x18
	[CompilerGenerated]
	[Token(Token = "0x4000A28")]
	private static OnGraphRegisteredDelegate onGraphUnregistered; //Field offset: 0x20
	[CompilerGenerated]
	[Token(Token = "0x4000A29")]
	private static OnExecutionRegisteredDelegate onExecutionRegistered; //Field offset: 0x28
	[Token(Token = "0x4000A2A")]
	private static bool s_DebugSessionWasActive; //Field offset: 0x30
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A03")]
	private NativePassCompiler nativeCompiler; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A05")]
	private bool <nativeRenderPassesEnabled>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A06")]
	internal RenderGraphResourceRegistry m_Resources; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A07")]
	private RenderGraphObjectPool m_RenderGraphPool; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A08")]
	private RenderGraphBuilders m_builderInstance; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A09")]
	internal List<RenderGraphPass> m_RenderPasses; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A0A")]
	private List<RendererListHandle> m_RendererLists; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A0B")]
	private RenderGraphDebugParams m_DebugParameters; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A0C")]
	private RenderGraphLogger m_FrameInformationLogger; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A0D")]
	private RenderGraphDefaultResources m_DefaultResources; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A0E")]
	private Dictionary<Int32, ProfilingSampler> m_DefaultProfilingSamplers; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000A0F")]
	private InternalRenderGraphContext m_RenderGraphContext; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000A10")]
	private CommandBuffer m_PreviousCommandBuffer; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000A11")]
	private List<Int32>[] m_ImmediateModeResourceList; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000A12")]
	private RenderGraphCompilationCache m_CompilationCache; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000A13")]
	private RenderTargetIdentifier[][] m_TempMRTArrays; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000A14")]
	private Stack<Int32> m_CullingStack; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000A15")]
	private EntityId m_CurrentExecutionId; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000A16")]
	private bool m_CurrentExecutionCanGenerateDebugData; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000A17")]
	private int m_ExecutionCount; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000A18")]
	private int m_CurrentFrameIndex; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000A19")]
	private int m_CurrentImmediatePassIndex; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000A1A")]
	private bool m_ExecutionExceptionWasRaised; //Field offset: 0xAC
	[FieldOffset(Offset = "0xAD")]
	[Token(Token = "0x4000A1B")]
	private bool m_RendererListCulling; //Field offset: 0xAD
	[FieldOffset(Offset = "0xAE")]
	[Token(Token = "0x4000A1C")]
	private bool m_EnableCompilationCaching; //Field offset: 0xAE
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000A1E")]
	private CompiledGraph m_DefaultCompiledGraph; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000A1F")]
	private CompiledGraph m_CurrentCompiledGraph; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000A20")]
	private RenderGraphState m_RenderGraphState; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4000A21")]
	private RenderTextureUVOriginStrategy m_renderTextureUVOriginStrategy; //Field offset: 0xC4
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000A23")]
	private string <name>k__BackingField; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000A2B")]
	private Dictionary<Int32, TextureHandle> registeredGlobals; //Field offset: 0xD0

	[Token(Token = "0x1400000C")]
	internal static event OnExecutionRegisteredDelegate onExecutionRegistered
	{
		[Address(RVA = "0x2C87500", Offset = "0x2C86900", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x6001045")]
		internal add { } //Length: 242
		[Address(RVA = "0x2C87AA0", Offset = "0x2C86EA0", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x6001046")]
		internal remove { } //Length: 242
	}

	[Token(Token = "0x1400000A")]
	internal static event OnGraphRegisteredDelegate onGraphRegistered
	{
		[Address(RVA = "0x2C87600", Offset = "0x2C86A00", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x6001041")]
		internal add { } //Length: 242
		[Address(RVA = "0x2C87BA0", Offset = "0x2C86FA0", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x6001042")]
		internal remove { } //Length: 242
	}

	[Token(Token = "0x1400000B")]
	internal static event OnGraphRegisteredDelegate onGraphUnregistered
	{
		[Address(RVA = "0x2C87700", Offset = "0x2C86B00", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x6001043")]
		internal add { } //Length: 242
		[Address(RVA = "0x2C87CA0", Offset = "0x2C870A0", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x6001044")]
		internal remove { } //Length: 242
	}

	[Token(Token = "0x1700021C")]
	internal bool areAnySettingsActive
	{
		[Address(RVA = "0x2C87800", Offset = "0x2C86C00", Length = "0x46")]
		[Token(Token = "0x6001000")]
		internal get { } //Length: 70
	}

	[Token(Token = "0x1700021B")]
	internal RenderGraphDebugParams debugParams
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000FFE")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700021A")]
	public RenderGraphDefaultResources defaultResources
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000FFA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000219")]
	internal static bool enableValidityChecks
	{
		[Address(RVA = "0x2C87850", Offset = "0x2C86C50", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6000FF8")]
		internal get { } //Length: 79
		[Address(RVA = "0x2C87DA0", Offset = "0x2C871A0", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x6000FF9")]
		private set { } //Length: 84
	}

	[Token(Token = "0x17000214")]
	internal static bool hasAnyRenderGraphWithNativeRenderPassesEnabled
	{
		[Address(RVA = "0x2C878A0", Offset = "0x2C86CA0", Length = "0x1B9")]
		[Token(Token = "0x6000FF0")]
		internal get { } //Length: 441
	}

	[Token(Token = "0x17000218")]
	public static bool isRenderGraphViewerActive
	{
		[Address(RVA = "0x2C87A60", Offset = "0x2C86E60", Length = "0x40")]
		[Token(Token = "0x6000FF7")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000215")]
	public private string name
	{
		[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000FF1")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEAE20", Offset = "0x1CEA220", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000FF2")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000213")]
	public bool nativeRenderPassesEnabled
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000FEE")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000FEF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000216")]
	internal RenderGraphState RenderGraphState
	{
		[Address(RVA = "0x1BC5710", Offset = "0x1BC4B10", Length = "0x7")]
		[Token(Token = "0x6000FF3")]
		internal get { } //Length: 7
		[Address(RVA = "0x21439F0", Offset = "0x2142DF0", Length = "0x7")]
		[Token(Token = "0x6000FF4")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000217")]
	public internal RenderTextureUVOriginStrategy renderTextureUVOriginStrategy
	{
		[Address(RVA = "0xE268F0", Offset = "0xE25CF0", Length = "0x7")]
		[Token(Token = "0x6000FF5")]
		 get { } //Length: 7
		[Address(RVA = "0xE26C20", Offset = "0xE26020", Length = "0x7")]
		[Token(Token = "0x6000FF6")]
		internal set { } //Length: 7
	}

	[Address(RVA = "0x2C86AB0", Offset = "0x2C85EB0", Length = "0x9D")]
	[Token(Token = "0x6001076")]
	private static RenderGraph() { }

	[Address(RVA = "0x2C86B50", Offset = "0x2C85F50", Length = "0x9A6")]
	[Token(Token = "0x6000FFB")]
	public RenderGraph(string name = "RenderGraph") { }

	[Address(RVA = "0x2C87500", Offset = "0x2C86900", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x6001045")]
	internal static void add_onExecutionRegistered(OnExecutionRegisteredDelegate value) { }

	[Address(RVA = "0x2C87600", Offset = "0x2C86A00", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x6001041")]
	internal static void add_onGraphRegistered(OnGraphRegisteredDelegate value) { }

	[Address(RVA = "0x2C87700", Offset = "0x2C86B00", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x6001043")]
	internal static void add_onGraphUnregistered(OnGraphRegisteredDelegate value) { }

	[Address(RVA = "0x8E74A0", Offset = "0x8E68A0", Length = "0x24B")]
	[Token(Token = "0x6001031")]
	public IComputeRenderGraphBuilder AddComputePass(string passName, out PassData passData, ProfilingSampler sampler, string file = "", int line = 0) { }

	[Address(RVA = "0x8E76F0", Offset = "0x8E6AF0", Length = "0x8E")]
	[Token(Token = "0x6001030")]
	public IComputeRenderGraphBuilder AddComputePass(string passName, out PassData passData, string file = "", int line = 0) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Token(Token = "0x6000FEB")]
	private void AddPassDebugMetadata(RenderGraphPass renderPass, string file, int line) { }

	[Address(RVA = "0x8E7810", Offset = "0x8E6C10", Length = "0x24B")]
	[Token(Token = "0x600102F")]
	public IRasterRenderGraphBuilder AddRasterRenderPass(string passName, out PassData passData, ProfilingSampler sampler, string file = "", int line = 0) { }

	[Address(RVA = "0x8E7780", Offset = "0x8E6B80", Length = "0x8E")]
	[Token(Token = "0x600102E")]
	public IRasterRenderGraphBuilder AddRasterRenderPass(string passName, out PassData passData, string file = "", int line = 0) { }

	[Address(RVA = "0x8E7A60", Offset = "0x8E6E60", Length = "0xB7")]
	[Obsolete("AddRenderPass() is deprecated, use AddRasterRenderPass/AddComputePass/AddUnsafePass() instead.")]
	[Token(Token = "0x6001035")]
	public RenderGraphBuilder AddRenderPass(string passName, out PassData passData, string file = "", int line = 0) { }

	[Address(RVA = "0x8E7B20", Offset = "0x8E6F20", Length = "0x24F")]
	[Obsolete("AddRenderPass() is deprecated, use AddRasterRenderPass/AddComputePass/AddUnsafePass() instead.")]
	[Token(Token = "0x6001034")]
	public RenderGraphBuilder AddRenderPass(string passName, out PassData passData, ProfilingSampler sampler, string file = "", int line = 0) { }

	[Address(RVA = "0x8E7D70", Offset = "0x8E7170", Length = "0x24F")]
	[Token(Token = "0x6001033")]
	public IUnsafeRenderGraphBuilder AddUnsafePass(string passName, out PassData passData, ProfilingSampler sampler, string file = "", int line = 0) { }

	[Address(RVA = "0x8E7FC0", Offset = "0x8E73C0", Length = "0x8E")]
	[Token(Token = "0x6001032")]
	public IUnsafeRenderGraphBuilder AddUnsafePass(string passName, out PassData passData, string file = "", int line = 0) { }

	[Address(RVA = "0x2C7BB70", Offset = "0x2C7AF70", Length = "0x47")]
	[Token(Token = "0x6001073")]
	internal ValueCollection<Int32, TextureHandle> AllGlobals() { }

	[Address(RVA = "0x2C7BBC0", Offset = "0x2C7AFC0", Length = "0x429")]
	[Token(Token = "0x6001054")]
	private void AllocateCulledPassResources(ref CompiledPassInfo passInfo) { }

	[Address(RVA = "0x2C7BFF0", Offset = "0x2C7B3F0", Length = "0x209")]
	[Token(Token = "0x6001057")]
	private bool AreRendererListsEmpty(List<RendererListHandle> rendererLists) { }

	[Address(RVA = "0x2C7C200", Offset = "0x2C7B600", Length = "0x277")]
	[Token(Token = "0x600103A")]
	public void BeginProfilingSampler(ProfilingSampler sampler, string file = "", int line = 0) { }

	[Address(RVA = "0x2C7C480", Offset = "0x2C7B880", Length = "0x45C")]
	[Token(Token = "0x6001036")]
	public void BeginRecording(in RenderGraphParameters parameters) { }

	[Address(RVA = "0x2C7C8E0", Offset = "0x2C7BCE0", Length = "0xF7")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600102C")]
	private void CheckNotUsedWhenActive() { }

	[Address(RVA = "0x2C7C9E0", Offset = "0x2C7BDE0", Length = "0xF7")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6001026")]
	private void CheckNotUsedWhenExecuting() { }

	[Address(RVA = "0x2C7CAE0", Offset = "0x2C7BEE0", Length = "0xF7")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600102D")]
	private void CheckNotUsedWhenIdle() { }

	[Address(RVA = "0x2C7CCE0", Offset = "0x2C7C0E0", Length = "0xF7")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6001027")]
	private void CheckNotUsedWhenRecordingGraph() { }

	[Address(RVA = "0x2C7CDE0", Offset = "0x2C7C1E0", Length = "0xF7")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6001029")]
	private void CheckNotUsedWhenRecordingPass() { }

	[Address(RVA = "0x2C7CBE0", Offset = "0x2C7BFE0", Length = "0x100")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6001028")]
	private void CheckNotUsedWhenRecordPassOrExecute() { }

	[Address(RVA = "0x2C7CEE0", Offset = "0x2C7C2E0", Length = "0xD3")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600102A")]
	private void CheckNotUsingNativeRenderPassCompiler() { }

	[Address(RVA = "0x2C7CFC0", Offset = "0x2C7C3C0", Length = "0xDA")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600102B")]
	private void CheckUsingNativeRenderPassCompiler() { }

	[Address(RVA = "0x2C7D250", Offset = "0x2C7C650", Length = "0xC9")]
	[Token(Token = "0x6000FFD")]
	public void Cleanup() { }

	[Address(RVA = "0x2C7D0A0", Offset = "0x2C7C4A0", Length = "0x1A9")]
	[Token(Token = "0x6000FFC")]
	internal void CleanupResourcesAndGraph() { }

	[Address(RVA = "0x2C7D320", Offset = "0x2C7C720", Length = "0xEE")]
	[Token(Token = "0x600106E")]
	private void ClearCacheIfNewActiveDebugSession() { }

	[Address(RVA = "0x2C7D410", Offset = "0x2C7C810", Length = "0xBD")]
	[Token(Token = "0x600103E")]
	private void ClearCompiledGraph(CompiledGraph compiledGraph, bool useCompilationCaching) { }

	[Address(RVA = "0x2C7D4D0", Offset = "0x2C7C8D0", Length = "0xAE")]
	[Token(Token = "0x600103D")]
	internal void ClearCurrentCompiledGraph() { }

	[Address(RVA = "0x2C7D580", Offset = "0x2C7C980", Length = "0x1FF")]
	[Token(Token = "0x6001075")]
	internal void ClearGlobalBindings() { }

	[Address(RVA = "0x2C7D780", Offset = "0x2C7CB80", Length = "0x167")]
	[Token(Token = "0x6001063")]
	private void ClearRenderPasses() { }

	[Address(RVA = "0x2C7D8F0", Offset = "0x2C7CCF0", Length = "0x2EB")]
	[Token(Token = "0x6000FEC")]
	internal NativePassCompiler CompileNativeRenderGraph(int graphHash) { }

	[Address(RVA = "0x2C7DBE0", Offset = "0x2C7CFE0", Length = "0x891")]
	[Token(Token = "0x600105C")]
	private CompiledPassInfo CompilePassImmediatly(RenderGraphPass pass) { }

	[Address(RVA = "0x2C7E480", Offset = "0x2C7D880", Length = "0x62C")]
	[Token(Token = "0x600105B")]
	internal void CompileRenderGraph(int graphHash) { }

	[Address(RVA = "0x2C7EAB0", Offset = "0x2C7DEB0", Length = "0x11D")]
	[Token(Token = "0x6001047")]
	internal int ComputeGraphHash() { }

	[Address(RVA = "0x2C7EBD0", Offset = "0x2C7DFD0", Length = "0x6DA")]
	[Token(Token = "0x6001048")]
	private void CountReferences() { }

	[Address(RVA = "0x2C7F300", Offset = "0x2C7E700", Length = "0x6A")]
	[Token(Token = "0x6001023")]
	public BufferHandle CreateBuffer(in BufferHandle graphicsBuffer) { }

	[Address(RVA = "0x2C7F2B0", Offset = "0x2C7E6B0", Length = "0x47")]
	[Token(Token = "0x6001022")]
	public BufferHandle CreateBuffer(in BufferDesc desc) { }

	[Address(RVA = "0x2C7F370", Offset = "0x2C7E770", Length = "0x59")]
	[Token(Token = "0x6001019")]
	public RendererListHandle CreateGizmoRendererList(in Camera camera, in GizmoSubset gizmoSubset) { }

	[Address(RVA = "0x2C7F3D0", Offset = "0x2C7E7D0", Length = "0x3B")]
	[Token(Token = "0x6001017")]
	public RendererListHandle CreateRendererList(in RendererListParams desc) { }

	[Address(RVA = "0x2C7F410", Offset = "0x2C7E810", Length = "0x3B")]
	[Token(Token = "0x6001016")]
	public RendererListHandle CreateRendererList(in RendererListDesc desc) { }

	[Address(RVA = "0x2C7F450", Offset = "0x2C7E850", Length = "0x120")]
	[Token(Token = "0x6001052")]
	private void CreateRendererLists() { }

	[Address(RVA = "0x2C7F580", Offset = "0x2C7E980", Length = "0x51")]
	[Token(Token = "0x6001018")]
	public RendererListHandle CreateShadowRendererList(ref ShadowDrawingSettings shadowDrawingSettings) { }

	[Address(RVA = "0x2C7F5E0", Offset = "0x2C7E9E0", Length = "0x39")]
	[Obsolete("CreateSharedTexture() and shared texture workflow are deprecated, use ImportTexture() workflow instead.")]
	[Token(Token = "0x600100E")]
	public TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease = false) { }

	[Address(RVA = "0x2C7F840", Offset = "0x2C7EC40", Length = "0x51")]
	[Token(Token = "0x600101D")]
	public RendererListHandle CreateSkyboxRendererList(in Camera camera) { }

	[Address(RVA = "0x2C7F620", Offset = "0x2C7EA20", Length = "0xC9")]
	[Token(Token = "0x600101E")]
	public RendererListHandle CreateSkyboxRendererList(in Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix) { }

	[Address(RVA = "0x2C7F6F0", Offset = "0x2C7EAF0", Length = "0x14C")]
	[Token(Token = "0x600101F")]
	public RendererListHandle CreateSkyboxRendererList(in Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR) { }

	[Address(RVA = "0x2C7FAA0", Offset = "0x2C7EEA0", Length = "0x3F")]
	[Token(Token = "0x600100D")]
	public TextureHandle CreateTexture(in TextureDesc desc) { }

	[Address(RVA = "0x2C7F970", Offset = "0x2C7ED70", Length = "0x129")]
	[Token(Token = "0x6001012")]
	public TextureHandle CreateTexture(TextureHandle texture, string name, bool clear = false) { }

	[Address(RVA = "0x2C7FAE0", Offset = "0x2C7EEE0", Length = "0x62")]
	[Token(Token = "0x6001011")]
	public TextureHandle CreateTexture(TextureHandle texture) { }

	[Address(RVA = "0x2C7F8A0", Offset = "0x2C7ECA0", Length = "0xC8")]
	[Token(Token = "0x6001013")]
	public void CreateTextureIfInvalid(in TextureDesc desc, ref TextureHandle texture) { }

	[Address(RVA = "0x2C7FBB0", Offset = "0x2C7EFB0", Length = "0x68")]
	[Token(Token = "0x600101A")]
	public RendererListHandle CreateUIOverlayRendererList(in Camera camera) { }

	[Address(RVA = "0x2C7FB50", Offset = "0x2C7EF50", Length = "0x59")]
	[Token(Token = "0x600101B")]
	public RendererListHandle CreateUIOverlayRendererList(in Camera camera, in UISubset uiSubset) { }

	[Address(RVA = "0x2C7FC20", Offset = "0x2C7F020", Length = "0x51")]
	[Token(Token = "0x600101C")]
	public RendererListHandle CreateWireOverlayRendererList(in Camera camera) { }

	[Address(RVA = "0x2C7FC80", Offset = "0x2C7F080", Length = "0x10A")]
	[Token(Token = "0x6001059")]
	private void CullRendererLists() { }

	[Address(RVA = "0x2C7FD90", Offset = "0x2C7F190", Length = "0x58B")]
	[Token(Token = "0x6001049")]
	private void CullUnusedPasses() { }

	[Address(RVA = "0x2C80320", Offset = "0x2C7F720", Length = "0x71")]
	[Token(Token = "0x6001005")]
	public void EndFrame() { }

	[Address(RVA = "0x2C803A0", Offset = "0x2C7F7A0", Length = "0x277")]
	[Token(Token = "0x600103B")]
	public void EndProfilingSampler(ProfilingSampler sampler, string file = "", int line = 0) { }

	[Address(RVA = "0x2C80620", Offset = "0x2C7FA20", Length = "0x197")]
	[Token(Token = "0x6001037")]
	public void EndRecordingAndExecute() { }

	[Address(RVA = "0x2C80DF0", Offset = "0x2C801F0", Length = "0xDF")]
	[Token(Token = "0x6001039")]
	internal void Execute() { }

	[Address(RVA = "0x2C807C0", Offset = "0x2C7FBC0", Length = "0x3EF")]
	[Token(Token = "0x600105E")]
	private void ExecuteCompiledPass(ref CompiledPassInfo passInfo) { }

	[Address(RVA = "0x2C80BB0", Offset = "0x2C7FFB0", Length = "0xD4")]
	[Token(Token = "0x6000FED")]
	private void ExecuteNativeRenderGraph() { }

	[Address(RVA = "0x2C80C90", Offset = "0x2C80090", Length = "0x24")]
	[Token(Token = "0x600105D")]
	private void ExecutePassImmediately(RenderGraphPass pass) { }

	[Address(RVA = "0x2C80CC0", Offset = "0x2C800C0", Length = "0x123")]
	[Token(Token = "0x600105F")]
	private void ExecuteRenderGraph() { }

	[Address(RVA = "0x2C80ED0", Offset = "0x2C802D0", Length = "0xE6")]
	[Token(Token = "0x600104D")]
	private int FindTextureProducer(int consumerPass, in CompiledResourceInfo info, out int index) { }

	[Address(RVA = "0x2C80FC0", Offset = "0x2C803C0", Length = "0x10CD")]
	[Token(Token = "0x6001070")]
	private void GenerateCompilerDebugData(ref DebugData debugData) { }

	[Address(RVA = "0x2C82090", Offset = "0x2C81490", Length = "0x816")]
	[Token(Token = "0x600106F")]
	private void GenerateDebugData(int graphHash) { }

	[Address(RVA = "0x2C87800", Offset = "0x2C86C00", Length = "0x46")]
	[Token(Token = "0x6001000")]
	internal bool get_areAnySettingsActive() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000FFE")]
	internal RenderGraphDebugParams get_debugParams() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000FFA")]
	public RenderGraphDefaultResources get_defaultResources() { }

	[Address(RVA = "0x2C87850", Offset = "0x2C86C50", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6000FF8")]
	internal static bool get_enableValidityChecks() { }

	[Address(RVA = "0x2C878A0", Offset = "0x2C86CA0", Length = "0x1B9")]
	[Token(Token = "0x6000FF0")]
	internal static bool get_hasAnyRenderGraphWithNativeRenderPassesEnabled() { }

	[Address(RVA = "0x2C87A60", Offset = "0x2C86E60", Length = "0x40")]
	[Token(Token = "0x6000FF7")]
	public static bool get_isRenderGraphViewerActive() { }

	[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000FF1")]
	public string get_name() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000FEE")]
	public bool get_nativeRenderPassesEnabled() { }

	[Address(RVA = "0x1BC5710", Offset = "0x1BC4B10", Length = "0x7")]
	[Token(Token = "0x6000FF3")]
	internal RenderGraphState get_RenderGraphState() { }

	[Address(RVA = "0xE268F0", Offset = "0xE25CF0", Length = "0x7")]
	[Token(Token = "0x6000FF5")]
	public RenderTextureUVOriginStrategy get_renderTextureUVOriginStrategy() { }

	[Address(RVA = "0x2C828B0", Offset = "0x2C81CB0", Length = "0x41")]
	[Token(Token = "0x6001024")]
	public BufferDesc GetBufferDesc(in BufferHandle graphicsBuffer) { }

	[Address(RVA = "0x2424EC0", Offset = "0x24242C0", Length = "0x1E")]
	[Token(Token = "0x600103C")]
	internal DynamicArray<CompiledPassInfo> GetCompiledPassInfos() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001069")]
	private ProfilingSampler GetDefaultProfilingSampler(string name) { }

	[Address(RVA = "0x2C82900", Offset = "0x2C81D00", Length = "0xC2")]
	[Token(Token = "0x600106D")]
	private static string GetExecutionNameAllocates(EntityId entityId) { }

	[Address(RVA = "0x2C829D0", Offset = "0x2C81DD0", Length = "0x17C")]
	[Token(Token = "0x600104C")]
	private int GetFirstValidConsumerIndex(int passIndex, in CompiledResourceInfo info) { }

	[Address(RVA = "0x2C82B50", Offset = "0x2C81F50", Length = "0xE2")]
	[Token(Token = "0x6001050")]
	private int GetFirstValidWriteIndex(in CompiledResourceInfo info) { }

	[Address(RVA = "0x2C82C40", Offset = "0x2C82040", Length = "0x6F")]
	[Token(Token = "0x6001074")]
	internal TextureHandle GetGlobal(int globalPropertyId) { }

	[Address(RVA = "0x2C82CB0", Offset = "0x2C820B0", Length = "0x33A")]
	[Token(Token = "0x6001053")]
	internal bool GetImportedFallback(TextureDesc desc, out TextureHandle fallback) { }

	[Address(RVA = "0x2C82FF0", Offset = "0x2C823F0", Length = "0x1AC")]
	[Token(Token = "0x600104E")]
	private int GetLatestProducerIndex(int passIndex, in CompiledResourceInfo info) { }

	[Address(RVA = "0x2C831A0", Offset = "0x2C825A0", Length = "0xEC")]
	[Token(Token = "0x600104F")]
	private int GetLatestValidReadIndex(in CompiledResourceInfo info) { }

	[Address(RVA = "0x2C83290", Offset = "0x2C82690", Length = "0xEC")]
	[Token(Token = "0x6001051")]
	private int GetLatestValidWriteIndex(in CompiledResourceInfo info) { }

	[Address(RVA = "0x2C83380", Offset = "0x2C82780", Length = "0x4F")]
	[Token(Token = "0x6001004")]
	internal static Dictionary<RenderGraph, List`1<DebugExecutionItem>> GetRegisteredExecutions() { }

	[Address(RVA = "0x2C833D0", Offset = "0x2C827D0", Length = "0xC4")]
	[Token(Token = "0x6001003")]
	public static List<RenderGraph> GetRegisteredRenderGraphs() { }

	[Address(RVA = "0x2C834A0", Offset = "0x2C828A0", Length = "0x3D")]
	[Token(Token = "0x6001015")]
	public RenderTargetInfo GetRenderTargetInfo(TextureHandle texture) { }

	[Address(RVA = "0x2C834E0", Offset = "0x2C828E0", Length = "0x6F")]
	[Token(Token = "0x6001014")]
	public TextureDesc GetTextureDesc(in TextureHandle texture) { }

	[Address(RVA = "0x2C83550", Offset = "0x2C82950", Length = "0x28")]
	[Token(Token = "0x6000FFF")]
	internal List<Widget> GetWidgetList() { }

	[Address(RVA = "0x2C83580", Offset = "0x2C82980", Length = "0x6A")]
	[Token(Token = "0x600100B")]
	public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt, RenderTargetInfo info, ImportResourceParams importParams = null) { }

	[Address(RVA = "0x2C835F0", Offset = "0x2C829F0", Length = "0xA9")]
	[Token(Token = "0x600100C")]
	public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt) { }

	[Address(RVA = "0x2C836A0", Offset = "0x2C82AA0", Length = "0x3B")]
	[Token(Token = "0x6001021")]
	public BufferHandle ImportBuffer(GraphicsBuffer graphicsBuffer) { }

	[Address(RVA = "0x2C836A0", Offset = "0x2C82AA0", Length = "0x3B")]
	[Obsolete("ImportBuffer with forceRelease parameter is deprecated. Use ImportBuffer without it instead. #from(6000.3)")]
	[Token(Token = "0x6001020")]
	public BufferHandle ImportBuffer(GraphicsBuffer graphicsBuffer, bool forceRelease = false) { }

	[Address(RVA = "0x2C836E0", Offset = "0x2C82AE0", Length = "0x41")]
	[Token(Token = "0x6001025")]
	public RayTracingAccelerationStructureHandle ImportRayTracingAccelerationStructure(in RayTracingAccelerationStructure accelStruct, string name = null) { }

	[Address(RVA = "0x2C83730", Offset = "0x2C82B30", Length = "0xE1")]
	[Token(Token = "0x6001007")]
	public TextureHandle ImportShadingRateImageTexture(RTHandle rt) { }

	[Address(RVA = "0x2C83930", Offset = "0x2C82D30", Length = "0x47")]
	[Token(Token = "0x6001008")]
	public TextureHandle ImportTexture(RTHandle rt, ImportResourceParams importParams) { }

	[Address(RVA = "0x2C83870", Offset = "0x2C82C70", Length = "0x66")]
	[Token(Token = "0x6001009")]
	public TextureHandle ImportTexture(RTHandle rt, RenderTargetInfo info, ImportResourceParams importParams = null) { }

	[Address(RVA = "0x2C83820", Offset = "0x2C82C20", Length = "0x42")]
	[Token(Token = "0x600100A")]
	internal TextureHandle ImportTexture(RTHandle rt, bool isBuiltin) { }

	[Address(RVA = "0x2C838E0", Offset = "0x2C82CE0", Length = "0x45")]
	[Token(Token = "0x6001006")]
	public TextureHandle ImportTexture(RTHandle rt) { }

	[Address(RVA = "0x2C83980", Offset = "0x2C82D80", Length = "0x7E")]
	[Token(Token = "0x600103F")]
	private void InvalidateContext() { }

	[Address(RVA = "0x2C83A00", Offset = "0x2C82E00", Length = "0x54")]
	[Token(Token = "0x6001072")]
	internal bool IsGlobal(int globalPropertyId) { }

	[Address(RVA = "0x2C83A60", Offset = "0x2C82E60", Length = "0x3D6")]
	[Token(Token = "0x6001068")]
	private void LogCulledPasses() { }

	[Address(RVA = "0x2C83E40", Offset = "0x2C83240", Length = "0x1D4")]
	[Token(Token = "0x6001065")]
	private void LogFrameInformation() { }

	[Address(RVA = "0x2C843F0", Offset = "0x2C837F0", Length = "0x123")]
	[Token(Token = "0x6001066")]
	private void LogRendererListsCreation() { }

	[Address(RVA = "0x2C84020", Offset = "0x2C83420", Length = "0x3C4")]
	[Token(Token = "0x6001067")]
	private void LogRenderPassBegin(in CompiledPassInfo passInfo) { }

	[Address(RVA = "0x2C84520", Offset = "0x2C83920", Length = "0x3E")]
	[Token(Token = "0x6001040")]
	internal void OnPassAdded(RenderGraphPass pass) { }

	[Address(RVA = "0x2C84560", Offset = "0x2C83960", Length = "0x4B5")]
	[Token(Token = "0x6001062")]
	private void PostRenderPassExecute(ref CompiledPassInfo passInfo, RenderGraphPass pass, InternalRenderGraphContext rgContext) { }

	[Address(RVA = "0x2C84A20", Offset = "0x2C83E20", Length = "0x418")]
	[Token(Token = "0x6001061")]
	private void PreRenderPassExecute(in CompiledPassInfo passInfo, RenderGraphPass pass, InternalRenderGraphContext rgContext) { }

	[Address(RVA = "0x2C84E40", Offset = "0x2C84240", Length = "0x599")]
	[Token(Token = "0x6001060")]
	private void PreRenderPassSetRenderTargets(in CompiledPassInfo passInfo, RenderGraphPass pass, InternalRenderGraphContext rgContext) { }

	[Address(RVA = "0x2C853E0", Offset = "0x2C847E0", Length = "0x1F")]
	[Obsolete("RefreshSharedTextureDesc() and shared texture workflow are deprecated, use ImportTexture() workflow instead.")]
	[Token(Token = "0x600100F")]
	public void RefreshSharedTextureDesc(TextureHandle handle, in TextureDesc desc) { }

	[Address(RVA = "0x2C85400", Offset = "0x2C84800", Length = "0x1A0")]
	[Token(Token = "0x6001001")]
	public void RegisterDebug(Panel panel = null) { }

	[Address(RVA = "0x2C855B0", Offset = "0x2C849B0", Length = "0xF5")]
	[Token(Token = "0x600106B")]
	private void RegisterGraph() { }

	[Address(RVA = "0x2C856B0", Offset = "0x2C84AB0", Length = "0x186")]
	[Token(Token = "0x6001064")]
	private void ReleaseImmediateModeResources() { }

	[Address(RVA = "0x2C85840", Offset = "0x2C84C40", Length = "0x1F")]
	[Obsolete("ReleaseSharedTexture() and shared texture workflow are deprecated, use ImportTexture() workflow instead.")]
	[Token(Token = "0x6001010")]
	public void ReleaseSharedTexture(TextureHandle texture) { }

	[Address(RVA = "0x2C87AA0", Offset = "0x2C86EA0", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x6001046")]
	internal static void remove_onExecutionRegistered(OnExecutionRegisteredDelegate value) { }

	[Address(RVA = "0x2C87BA0", Offset = "0x2C86FA0", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x6001042")]
	internal static void remove_onGraphRegistered(OnGraphRegisteredDelegate value) { }

	[Address(RVA = "0x2C87CA0", Offset = "0x2C870A0", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x6001044")]
	internal static void remove_onGraphUnregistered(OnGraphRegisteredDelegate value) { }

	[Address(RVA = "0x2C85860", Offset = "0x2C84C60", Length = "0x104")]
	[Token(Token = "0x6001038")]
	public bool ResetGraphAndLogException(Exception e) { }

	[Address(RVA = "0x2C87DA0", Offset = "0x2C871A0", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x6000FF9")]
	private static void set_enableValidityChecks(bool value) { }

	[Address(RVA = "0x1CEAE20", Offset = "0x1CEA220", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000FF2")]
	private void set_name(string value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000FEF")]
	public void set_nativeRenderPassesEnabled(bool value) { }

	[Address(RVA = "0x21439F0", Offset = "0x2142DF0", Length = "0x7")]
	[Token(Token = "0x6000FF4")]
	internal void set_RenderGraphState(RenderGraphState value) { }

	[Address(RVA = "0xE26C20", Offset = "0xE26020", Length = "0x7")]
	[Token(Token = "0x6000FF6")]
	internal void set_renderTextureUVOriginStrategy(RenderTextureUVOriginStrategy value) { }

	[Address(RVA = "0x2C85970", Offset = "0x2C84D70", Length = "0x119")]
	[Token(Token = "0x6001071")]
	internal void SetGlobal(in TextureHandle h, int globalPropertyId) { }

	[Address(RVA = "0x2C85A90", Offset = "0x2C84E90", Length = "0xCA")]
	[Token(Token = "0x6001058")]
	private void TryCullPassAtIndex(int passIndex) { }

	[Address(RVA = "0x2C85B60", Offset = "0x2C84F60", Length = "0x7F")]
	[Token(Token = "0x6001002")]
	public void UnRegisterDebug() { }

	[Address(RVA = "0x2C85BE0", Offset = "0x2C84FE0", Length = "0xAC")]
	[Token(Token = "0x600106C")]
	private void UnregisterGraph() { }

	[Address(RVA = "0x2C85C90", Offset = "0x2C85090", Length = "0x14F")]
	[Token(Token = "0x6001056")]
	private void UpdateAllSharedResourceLastFrameIndex() { }

	[Address(RVA = "0x2C85DE0", Offset = "0x2C851E0", Length = "0x6E")]
	[Token(Token = "0x600105A")]
	private bool UpdateCurrentCompiledGraph(int graphHash, bool forceNoCaching = false) { }

	[Address(RVA = "0x2C85E50", Offset = "0x2C85250", Length = "0x197")]
	[Token(Token = "0x600106A")]
	private void UpdateImportedResourceLifeTime(ref ResourceData data, List<Int32> passList) { }

	[Address(RVA = "0x2C85FF0", Offset = "0x2C853F0", Length = "0x1F")]
	[Token(Token = "0x600104A")]
	private void UpdatePassSynchronization(ref CompiledPassInfo currentPassInfo, ref CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex) { }

	[Address(RVA = "0x2C86010", Offset = "0x2C85410", Length = "0x95F")]
	[Token(Token = "0x6001055")]
	private void UpdateResourceAllocationAndSynchronization() { }

	[Address(RVA = "0x2C86970", Offset = "0x2C85D70", Length = "0x13B")]
	[Token(Token = "0x600104B")]
	private void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, in CompiledResourceInfo resource) { }

}

