/*
123                  // decimal, int
10_543_765Lu         // decimal, ulong
1_2__3___4____5      // decimal, int
_123                 // not a numeric literal; identifier due to leading _
123_                 // invalid; no trailing _allowed

0xFf                 // hex, int
0X1b_a0_44_fEL       // hex, long
0x1ade_3FE1_29AaUL   // hex, ulong
0x_abc               // hex, int
_0x123               // not a numeric literal; identifier due to leading _
0xabc_               // invalid; no trailing _ allowed

0b101                // binary, int
0B1001_1010u         // binary, uint
0b1111_1111_0000UL   // binary, ulong
0B__111              // binary, int
__0B111              // not a numeric literal; identifier due to leading _
0B111__              // invalid; no trailing _ allowed

*/

123
10_543_765Lu
1_2__3___4____5
_123
123_

0xFf
0X1b_a0_44_fEL
0x1ade_3FE1_29AaUL
0x_abc
_0x123
0xabc_

0b101
0B1001_1010u
0b1111_1111_0000UL
0B__111
__0B111
0B111__