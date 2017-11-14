using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3
{
	public class ActorMovement : MemoryObject
	{
		// 2.0.3.22427
		public const int SizeOf = 0x290;

		public int x000_VTable { get { return ReadPointer<int>(0x000).Dereference(); } }
		public int x004_12 { get { return Read<int>(0x004); } }
		public int x008 { get { return Read<int>(0x008); } }
		public int x00C { get { return Read<int>(0x00C); } }
		public int x010_Float1 { get { return Read<int>(0x010); } }
		public int x014 { get { return Read<int>(0x014); } }
		public int x018 { get { return Read<int>(0x018); } }
		public float x01C_Float1 { get { return Read<float>(0x01C); } }
		public int x020_Neg1 { get { return Read<int>(0x020); } }
		public int x024_Neg1 { get { return Read<int>(0x024); } }
		public int x028 { get { return Read<int>(0x028); } }
		public int x02C_Neg1 { get { return Read<int>(0x02C); } }
		public int x030_Neg1 { get { return Read<int>(0x030); } }
		public int x034 { get { return Read<int>(0x034); } }
		public int _x038 { get { return Read<int>(0x038); } }
		public int _x03C { get { return Read<int>(0x03C); } }
		public int x040 { get { return Read<int>(0x040); } }
		public int x044 { get { return Read<int>(0x044); } }
		public int x048 { get { return Read<int>(0x048); } }
		public int x04C_Neg1 { get { return Read<int>(0x04C); } }
		public int x050 { get { return Read<int>(0x050); } }
		public int x054 { get { return Read<int>(0x054); } }
		public int x058 { get { return Read<int>(0x058); } }
		public int x05C_Neg1 { get { return Read<int>(0x05C); } }
		public int x060 { get { return Read<int>(0x060); } }
		public int x064 { get { return Read<int>(0x064); } }
		public int x068 { get { return Read<int>(0x068); } }
		public int x06C { get { return Read<int>(0x06C); } }
		public int x070 { get { return Read<int>(0x070); } }
		public int x074 { get { return Read<int>(0x074); } }
		public int x078 { get { return Read<int>(0x078); } }
		public int x07C { get { return Read<int>(0x07C); } }
		public int x080 { get { return Read<int>(0x080); } }
		public int x084 { get { return Read<int>(0x084); } }
		public int x088 { get { return Read<int>(0x088); } }
		public int x08C { get { return Read<int>(0x08C); } }
		public int x090 { get { return Read<int>(0x090); } }
		public int x094 { get { return Read<int>(0x094); } }
		public int x098 { get { return Read<int>(0x098); } }
		public int x09C { get { return Read<int>(0x09C); } }
		public int x0A0 { get { return Read<int>(0x0A0); } }
		public int x0A4 { get { return Read<int>(0x0A4); } }
		public int x0A8_Neg1 { get { return Read<int>(0x0A8); } }
		public int x0AC { get { return Read<int>(0x0AC); } }
		public int x0B0 { get { return Read<int>(0x0B0); } }
		public int x0B4 { get { return Read<int>(0x0B4); } }
		public int x0B8 { get { return Read<int>(0x0B8); } }
		public int x0BC { get { return Read<int>(0x0BC); } }
		public int x0C0 { get { return Read<int>(0x0C0); } }
		public int x0C4 { get { return Read<int>(0x0C4); } }
		public int x0C8 { get { return Read<int>(0x0C8); } }
		public int x0CC_CurrentTick { get { return Read<int>(0x0CC); } }
		public int x0D0 { get { return Read<int>(0x0D0); } }
		public int x0D4_StructStart_Min8Bytes { get { return Read<int>(0x0D4); } }
		public int _x0D8 { get { return Read<int>(0x0D8); } }
		public int x0DC { get { return Read<int>(0x0DC); } }
		public int x0E0 { get { return Read<int>(0x0E0); } }
		public int x0E4 { get { return Read<int>(0x0E4); } }
		public int x0E8 { get { return Read<int>(0x0E8); } }
		public int x0EC { get { return Read<int>(0x0EC); } }
		public int x0F0 { get { return Read<int>(0x0F0); } }
		public int x0F4 { get { return Read<int>(0x0F4); } }
		public int x0F8 { get { return Read<int>(0x0F8); } }
		public int x0FC { get { return Read<int>(0x0FC); } }
		public int x100 { get { return Read<int>(0x100); } }
		public int x104 { get { return Read<int>(0x104); } }
		public int x108 { get { return Read<int>(0x108); } }
		public int x10C { get { return Read<int>(0x10C); } }
		public int x110_StructStart_120Bytes { get { return Read<int>(0x110); } }
		public int _x114 { get { return Read<int>(0x114); } }
		public int _x118 { get { return Read<int>(0x118); } }
		public int _x11C { get { return Read<int>(0x11C); } }
		public int _x120 { get { return Read<int>(0x120); } }
		public int _x124 { get { return Read<int>(0x124); } }
		public int _x128 { get { return Read<int>(0x128); } }
		public int _x12C { get { return Read<int>(0x12C); } }
		public int _x130 { get { return Read<int>(0x130); } }
		public int _x134 { get { return Read<int>(0x134); } }
		public int _x138 { get { return Read<int>(0x138); } }
		public int _x13C { get { return Read<int>(0x13C); } }
		public int _x140 { get { return Read<int>(0x140); } }
		public int _x144 { get { return Read<int>(0x144); } }
		public int _x148 { get { return Read<int>(0x148); } }
		public int _x14C { get { return Read<int>(0x14C); } }
		public int _x150 { get { return Read<int>(0x150); } }
		public int _x154 { get { return Read<int>(0x154); } }
		public int _x158 { get { return Read<int>(0x158); } }
		public int _x15C { get { return Read<int>(0x15C); } }
		public int _x160 { get { return Read<int>(0x160); } }
		public int _x164 { get { return Read<int>(0x164); } }
		public int _x168 { get { return Read<int>(0x168); } }
		public int _x16C { get { return Read<int>(0x16C); } }
		public int _x170 { get { return Read<int>(0x170); } }
		public int _x174 { get { return Read<int>(0x174); } }
		public int _x178 { get { return Read<int>(0x178); } }
		public int _x17C { get { return Read<int>(0x17C); } }
		public int _x180 { get { return Read<int>(0x180); } }
		public int _x184 { get { return Read<int>(0x184); } }
		public int x188_StructStart_Min56Bytes { get { return Read<int>(0x188); } }
		public int _x18C { get { return Read<int>(0x18C); } }
		public int x190 { get { return Read<int>(0x190); } }
		public int _x194 { get { return Read<int>(0x194); } }
		public int _x198 { get { return Read<int>(0x198); } }
		public int _x19C { get { return Read<int>(0x19C); } }
		public int _x1A0 { get { return Read<int>(0x1A0); } }
		public int _x1A4 { get { return Read<int>(0x1A4); } }
		public int _x1A8 { get { return Read<int>(0x1A8); } }
		public int _x1AC { get { return Read<int>(0x1AC); } }
		public int _x1B0 { get { return Read<int>(0x1B0); } }
		public int _x1B4 { get { return Read<int>(0x1B4); } }
		public int _x1B8 { get { return Read<int>(0x1B8); } }
		public int _x1BC { get { return Read<int>(0x1BC); } }
		public int x1C0_ActorId { get { return Read<int>(0x1C0); } }
		public int x1C4 { get { return Read<int>(0x1C4); } }
		public int x1C8 { get { return Read<int>(0x1C8); } }
		public int x1CC { get { return Read<int>(0x1CC); } }
		public int x1D0 { get { return Read<int>(0x1D0); } }
		public float x1D4 { get { return Read<float>(0x1D4); } }
		public int x1D8 { get { return Read<int>(0x1D8); } }
		public int x1DC { get { return Read<int>(0x1DC); } }
		public int x1E0 { get { return Read<int>(0x1E0); } }
		public int x1E4_Float1 { get { return Read<int>(0x1E4); } }
		public float x1E8 { get { return Read<float>(0x1E8); } }
		public int x1EC { get { return Read<int>(0x1EC); } }
		public int x1F0 { get { return Read<int>(0x1F0); } }
		public int x1F4 { get { return Read<int>(0x1F4); } }
		public int x1F8 { get { return Read<int>(0x1F8); } }
		public int x1FC { get { return Read<int>(0x1FC); } }
		public int x200 { get { return Read<int>(0x200); } }
		public int x204_StructStart_100Bytes { get { return Read<int>(0x204); } }
		public int _x208 { get { return Read<int>(0x208); } }
		public int _x20C { get { return Read<int>(0x20C); } }
		public int _x210 { get { return Read<int>(0x210); } }
		public int _x214 { get { return Read<int>(0x214); } }
		public int _x218 { get { return Read<int>(0x218); } }
		public int _x21C { get { return Read<int>(0x21C); } }
		public int _x220 { get { return Read<int>(0x220); } }
		public int _x224 { get { return Read<int>(0x224); } }
		public int _x228 { get { return Read<int>(0x228); } }
		public int _x22C { get { return Read<int>(0x22C); } }
		public int _x230 { get { return Read<int>(0x230); } }
		public int _x234 { get { return Read<int>(0x234); } }
		public int _x238 { get { return Read<int>(0x238); } }
		public int _x23C { get { return Read<int>(0x23C); } }
		public int _x240 { get { return Read<int>(0x240); } }
		public int _x244 { get { return Read<int>(0x244); } }
		public int _x248 { get { return Read<int>(0x248); } }
		public int _x24C { get { return Read<int>(0x24C); } }
		public int _x250 { get { return Read<int>(0x250); } }
		public int _x254 { get { return Read<int>(0x254); } }
		public int _x258 { get { return Read<int>(0x258); } }
		public int _x25C { get { return Read<int>(0x25C); } }
		public int _x260 { get { return Read<int>(0x260); } }
		public int _x264 { get { return Read<int>(0x264); } }
		public int x268 { get { return Read<int>(0x268); } }
		public int x26C { get { return Read<int>(0x26C); } }
		public int x270 { get { return Read<int>(0x270); } }
		public int x274 { get { return Read<int>(0x274); } }
		public int x278 { get { return Read<int>(0x278); } }
		public int x27C { get { return Read<int>(0x27C); } }
		public int x280_Neg1 { get { return Read<int>(0x280); } }
		public int x284_Float_100k { get { return Read<int>(0x284); } }
		public int x288_Float_100k { get { return Read<int>(0x288); } }
		public int x28C_Float_100k { get { return Read<int>(0x28C); } }
	}
}
