namespace UnityEngine.ResourceManagement.ResourceLocations;

[Token(Token = "0x200006C")]
public interface ILocationSizeData
{

	[Token(Token = "0x6000269")]
	public long ComputeSize(IResourceLocation location, ResourceManager resourceManager) { }

}

