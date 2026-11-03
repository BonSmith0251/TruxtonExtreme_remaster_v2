namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x2000023")]
internal static class SID
{
	[Token(Token = "0x40000B6")]
	public static readonly int g_vertices; //Field offset: 0x0
	[Token(Token = "0x40000B7")]
	public static readonly int g_indices; //Field offset: 0x4
	[Token(Token = "0x40000B8")]
	public static readonly int g_scratch_buffer; //Field offset: 0x8
	[Token(Token = "0x40000B9")]
	public static readonly int g_bvh; //Field offset: 0xC
	[Token(Token = "0x40000BA")]
	public static readonly int g_bvh_leaves; //Field offset: 0x10
	[Token(Token = "0x40000BB")]
	public static readonly int g_buffer; //Field offset: 0x14
	[Token(Token = "0x40000BC")]
	public static readonly int g_primitive_refs_offset; //Field offset: 0x18
	[Token(Token = "0x40000BD")]
	public static readonly int g_morton_codes_offset; //Field offset: 0x1C
	[Token(Token = "0x40000BE")]
	public static readonly int g_constants_num_keys; //Field offset: 0x20
	[Token(Token = "0x40000BF")]
	public static readonly int g_constants_input_keys_offset; //Field offset: 0x24
	[Token(Token = "0x40000C0")]
	public static readonly int g_constants_part_sums_offset; //Field offset: 0x28
	[Token(Token = "0x40000C1")]
	public static readonly int g_constants_output_keys_offset; //Field offset: 0x2C
	[Token(Token = "0x40000C2")]
	public static readonly int g_constants_num_blocks; //Field offset: 0x30
	[Token(Token = "0x40000C3")]
	public static readonly int g_constants_bit_shift; //Field offset: 0x34
	[Token(Token = "0x40000C4")]
	public static readonly int g_input_keys_offset; //Field offset: 0x38
	[Token(Token = "0x40000C5")]
	public static readonly int g_group_histograms_offset; //Field offset: 0x3C
	[Token(Token = "0x40000C6")]
	public static readonly int g_output_keys_offset; //Field offset: 0x40
	[Token(Token = "0x40000C7")]
	public static readonly int g_input_values_offset; //Field offset: 0x44
	[Token(Token = "0x40000C8")]
	public static readonly int g_output_values_offset; //Field offset: 0x48
	[Token(Token = "0x40000C9")]
	public static readonly int g_aabb_offset; //Field offset: 0x4C
	[Token(Token = "0x40000CA")]
	public static readonly int g_constants_vertex_stride; //Field offset: 0x50
	[Token(Token = "0x40000CB")]
	public static readonly int g_constants_triangle_count; //Field offset: 0x54
	[Token(Token = "0x40000CC")]
	public static readonly int g_constants_ray_count; //Field offset: 0x58
	[Token(Token = "0x40000CD")]
	public static readonly int g_ray_count; //Field offset: 0x5C
	[Token(Token = "0x40000CE")]
	public static readonly int g_rays; //Field offset: 0x60
	[Token(Token = "0x40000CF")]
	public static readonly int g_hits; //Field offset: 0x64
	[Token(Token = "0x40000D0")]
	public static readonly int g_constants_min_prims_per_treelet; //Field offset: 0x68
	[Token(Token = "0x40000D1")]
	public static readonly int g_treelet_count_offset; //Field offset: 0x6C
	[Token(Token = "0x40000D2")]
	public static readonly int g_treelet_roots_offset; //Field offset: 0x70
	[Token(Token = "0x40000D3")]
	public static readonly int g_primitive_counts_offset; //Field offset: 0x74
	[Token(Token = "0x40000D4")]
	public static readonly int g_treelet_dispatch_buffer; //Field offset: 0x78
	[Token(Token = "0x40000D5")]
	public static readonly int g_treelet_offset; //Field offset: 0x7C
	[Token(Token = "0x40000D6")]
	public static readonly int g_remainder_treelets; //Field offset: 0x80
	[Token(Token = "0x40000D7")]
	public static readonly int g_bvh_offset; //Field offset: 0x84
	[Token(Token = "0x40000D8")]
	public static readonly int g_bvh_leaves_offset; //Field offset: 0x88
	[Token(Token = "0x40000D9")]
	public static readonly int g_instance_infos; //Field offset: 0x8C
	[Token(Token = "0x40000DA")]
	public static readonly int g_bottom_bvhs; //Field offset: 0x90
	[Token(Token = "0x40000DB")]
	public static readonly int g_indices_offset; //Field offset: 0x94
	[Token(Token = "0x40000DC")]
	public static readonly int g_base_index; //Field offset: 0x98
	[Token(Token = "0x40000DD")]
	public static readonly int g_vertices_offset; //Field offset: 0x9C
	[Token(Token = "0x40000DE")]
	public static readonly int g_bvh_node_count; //Field offset: 0xA0
	[Token(Token = "0x40000DF")]
	public static readonly int g_trace_index_buffer; //Field offset: 0xA4
	[Token(Token = "0x40000E0")]
	public static readonly int g_trace_vertex_buffer; //Field offset: 0xA8
	[Token(Token = "0x40000E1")]
	public static readonly int g_trace_vertex_stride; //Field offset: 0xAC
	[Token(Token = "0x40000E2")]
	public static readonly int g_sorted_prim_refs_offset; //Field offset: 0xB0
	[Token(Token = "0x40000E3")]
	public static readonly int g_temp_indices_offset; //Field offset: 0xB4
	[Token(Token = "0x40000E4")]
	public static readonly int g_internal_node_range_offset; //Field offset: 0xB8
	[Token(Token = "0x40000E5")]
	public static readonly int g_cluster_validity_offset; //Field offset: 0xBC
	[Token(Token = "0x40000E6")]
	public static readonly int g_cluster_range_offset; //Field offset: 0xC0
	[Token(Token = "0x40000E7")]
	public static readonly int g_neighbor_offset; //Field offset: 0xC4
	[Token(Token = "0x40000E8")]
	public static readonly int g_cluster_to_node_offset; //Field offset: 0xC8
	[Token(Token = "0x40000E9")]
	public static readonly int g_deltas_offset; //Field offset: 0xCC
	[Token(Token = "0x40000EA")]
	public static readonly int g_leaf_parents_offset; //Field offset: 0xD0

	[Address(RVA = "0x2F5F530", Offset = "0x2F5E930", Length = "0x94E")]
	[Token(Token = "0x6000054")]
	private static SID() { }

}

