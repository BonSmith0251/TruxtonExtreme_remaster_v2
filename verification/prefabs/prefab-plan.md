# Prefab plan

142 prefabs, 105 moves, root `Assets/Prefabs`.

| Folder | Prefabs |
| --- | --- |
| Dedup/BG03 | 37 |
| Effects | 38 |
| Enemies | 20 |
| Environment | 3 |
| Pickups | 34 |
| Player | 1 |
| Projectiles | 9 |

| Prefab | Now | Goes to | Why | Notes |
| --- | --- | --- | --- | --- |
| bg03_rock_pillar_600 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| light | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| mountain_200_a_pipe | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| mountain_200_b_pipe | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| mountain_250_a _pipe | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| mountain_250_a | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| mountain_250_a_crater | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_bg03_bridge_a | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) | nests 1 |
| pf_bg03_bridge_set1 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) | nests 1 |
| pf_bg03_mecha_obj_01a | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_bg03_mecha_obj_02a | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_bg03_mecha_obj_03a | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_bg03_meteo_01a | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_bg03_meteo_set1 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) | nests 1 |
| pf_bg03_mountain_200_a | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) | nests 1 |
| pf_bg03_mountain_200_b | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) | nests 2 |
| pf_bg03_pipe_b | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) | nests 1 |
| pf_bg03_rock_100_a | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_bg03_rock_200_b | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_bg03_rock_200_b__2 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_bg03_rock_pillar_400 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_bg03_rock_pillar_600 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) | nests 1 |
| pf_bg03_rock_thorn_a | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_bg03_tower_a | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_eff_bg03_cloud01 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_eff_bg03_cloud02 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_eff_bg03_cloud02__2 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_eff_bg03_cloud03 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_eff_bg03_dust02 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_eff_bg03_dust03 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_eff_bg03_fire1 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_eff_bg03_fire2 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) | nests 1 |
| pf_eff_bg03_mountain_fire2 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_eff_bg03_smoke02 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_eff_bg03_star01 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_eff_bg03_volume_light1 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) |  |
| pf_ground_set1 | Assets/Prefabs/Dedup/BG03 | same | kept (/Dedup/) | nests 2 |
| BombBurst | Assets/Prefabs/Gameplay | Assets/Prefabs/Effects | rule 5 (name_re=(^|[_\-])(eff|fx|vfx|sfx)([_\-\d]|$)|explosion|explo) |  |
| pf_bs03 | Assets/Prefabs | Assets/Prefabs/Effects | rule 12 (has_any=['ParticleSystem', 'VisualEffect', 'TrailRenderer', ) | named in 1 file(s) |
| pf_eff_burner_p01 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_demo_boost01 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_e_laser_energy01 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) | named in 1 file(s) |
| pf_eff_e_laser_muzzle01 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) | named in 1 file(s) |
| pf_eff_e_muzzle01 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_e_muzzle02 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_e_muzzle03 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_explosion_meteor01 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) | named in 4 file(s) |
| pf_eff_explosion_meteor02 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) | named in 4 file(s) |
| pf_eff_explosion_meteor03 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) | named in 4 file(s) |
| pf_eff_explposion01 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) | named in 10 file(s) |
| pf_eff_explposion02 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) | named in 11 file(s) |
| pf_eff_explposion03 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) | named in 10 file(s) |
| pf_eff_explposion04 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) | named in 5 file(s) |
| pf_eff_explposion05 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) | named in 6 file(s) |
| pf_eff_explposion_boss | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) | named in 6 file(s) |
| pf_eff_explposion_p | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) | named in 1 file(s) |
| pf_eff_p_hit10_ingame | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_hit20_ingame | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_hit30_ingame | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_hit30_tip | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_hit40_ingame | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_hit40_tip | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_hit50_ingame | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_hit60_ingame | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_hit70_ingame | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_hit70_tip | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_muzzle10 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_muzzle20 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_muzzle30 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_muzzle40 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_muzzle50 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_muzzle60 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_eff_p_muzzle70 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) |  |
| pf_Point Light_explosion | Assets/Prefabs | Assets/Prefabs/Effects | rule 5 (name_re=(^|[_\-])(eff|fx|vfx|sfx)([_\-\d]|$)|explosion|explo) |  |
| sp_eff_pshot_10 | Assets/Prefabs | Assets/Prefabs/Effects | rule 3 (name_re=^(pf|sp)_eff_) | named in 2 file(s), unused |
| Pf_Ene_BMa01 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 23 file(s) |
| Pf_Ene_BSa01 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 16 file(s) |
| Pf_Ene_BSb01 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 19 file(s) |
| Pf_Ene_BSc01 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 24 file(s) |
| Pf_Ene_Lb01 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 14 file(s) |
| Pf_Ene_Ma01 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 15 file(s) |
| Pf_Ene_Md01 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 18 file(s) |
| Pf_Ene_Me01 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 14 file(s) |
| Pf_Ene_Mj01b | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 9 file(s) |
| Pf_Ene_Mj01h | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 21 file(s) |
| Pf_Ene_Mx01 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 18 file(s) |
| Pf_Ene_Sa01 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 18 file(s) |
| Pf_Ene_Sd01 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 17 file(s) |
| Pf_Ene_Se01 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 16 file(s) |
| Pf_EneObj_BurntGround01 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 1 file(s) |
| Pf_EneObj_BurntGround02 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 2 file(s) |
| Pf_EneObj_BurntGround03 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 1 file(s) |
| Pf_EneObj_Meteo_La02 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 14 file(s) |
| Pf_EneObj_Meteo_Ma02 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 14 file(s) |
| Pf_EneObj_Meteo_Sa02 | Assets/Prefabs | Assets/Prefabs/Enemies | rule 9 (name_re=enemy|(^|[_\-])ene([_\-]|obj|$)|(^|[_\-])mob([_\-\d]) | named in 14 file(s) |
| BG03 | Assets/Prefabs | Assets/Prefabs/Environment | rule 11 (name_re=(^|[_\-])(bg|env|prop|rock|tree|mountain|terrain|gro) | named in 14 file(s), nests 32 |
| Pf_BGObj_ColorBox00_UN | Assets/Prefabs | Assets/Prefabs/Environment | rule 11 (name_re=(^|[_\-])(bg|env|prop|rock|tree|mountain|terrain|gro) | named in 24 file(s) |
| Pf_BGObj_ColorBox01 | Assets/Prefabs | Assets/Prefabs/Environment | rule 11 (name_re=(^|[_\-])(bg|env|prop|rock|tree|mountain|terrain|gro) | named in 12 file(s) |
| pf_item01_bomber | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item01_change | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item01_power | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item02_1up | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item02_2up | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item02_3up | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item03_bonus01 | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item04_bom_stock | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item05_speed_down | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item05_speed_up | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item06_change_black | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item06_change_blue | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item06_change_gold | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item06_change_green | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item06_change_purple | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item06_change_red | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item06_change_silver | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| Pf_item_1up | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 8 file(s) |
| Pf_item_2up | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 3 file(s) |
| Pf_item_bomstock | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 6 file(s) |
| Pf_item_bonus01 | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 4 file(s) |
| Pf_Item_Box01 | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 7 file(s) |
| Pf_Item_Box02 | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 22 file(s) |
| Pf_item_change_black | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 3 file(s) |
| Pf_item_change_blue | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 4 file(s) |
| Pf_item_change_gold | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 3 file(s) |
| Pf_item_change_green | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 4 file(s) |
| Pf_item_change_purple | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 4 file(s) |
| Pf_item_change_red | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 4 file(s) |
| Pf_item_change_silver | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 4 file(s) |
| pf_item_points1 | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| pf_item_points2 | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 1 file(s) |
| Pf_item_power | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 7 file(s) |
| Pf_item_speedup | Assets/Prefabs | Assets/Prefabs/Pickups | rule 7 (name_re=item|pickup|coin|powerup|power_up|collect|gem|loot|c) | named in 5 file(s) |
| player01 | Assets/Prefabs | Assets/Prefabs/Player | rule 8 (name_re=player|hero|avatar) |  |
| EnemyBullet | Assets/Prefabs/Gameplay | Assets/Prefabs/Projectiles | rule 4 (name_re=bullet|projectile|missile|laser|(^|_)shot|beam|rocke) |  |
| enemybullet001 | Assets/Prefabs | Assets/Prefabs/Projectiles | rule 4 (name_re=bullet|projectile|missile|laser|(^|_)shot|beam|rocke) | named in 4 file(s) |
| enemybullet002 | Assets/Prefabs | Assets/Prefabs/Projectiles | rule 4 (name_re=bullet|projectile|missile|laser|(^|_)shot|beam|rocke) | named in 4 file(s) |
| enemybullet003 | Assets/Prefabs | Assets/Prefabs/Projectiles | rule 4 (name_re=bullet|projectile|missile|laser|(^|_)shot|beam|rocke) | named in 4 file(s) |
| enemybullet004 | Assets/Prefabs | Assets/Prefabs/Projectiles | rule 4 (name_re=bullet|projectile|missile|laser|(^|_)shot|beam|rocke) | named in 5 file(s) |
| enemybullet005 | Assets/Prefabs | Assets/Prefabs/Projectiles | rule 4 (name_re=bullet|projectile|missile|laser|(^|_)shot|beam|rocke) | named in 4 file(s) |
| enemybullet006 | Assets/Prefabs | Assets/Prefabs/Projectiles | rule 4 (name_re=bullet|projectile|missile|laser|(^|_)shot|beam|rocke) | named in 5 file(s) |
| enemylaser000 | Assets/Prefabs | Assets/Prefabs/Projectiles | rule 4 (name_re=bullet|projectile|missile|laser|(^|_)shot|beam|rocke) | named in 4 file(s), unused |
| PlayerBullet | Assets/Prefabs/Gameplay | Assets/Prefabs/Projectiles | rule 4 (name_re=bullet|projectile|missile|laser|(^|_)shot|beam|rocke) |  |
