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

1.234_567      // double
.3e5f          // float
2_345E-2_0     // double
15D            // double
19.73M         // decimal
1.F            // parsed as a member access of F due to non-digit after .
1_.2F          // invalid; no trailing _ allowed in integer part
1._234         // parsed as a member access of _234 due to non-digit after .
1.234_         // invalid; no trailing _ allowed in fraction
.3e_5F         // invalid; no leading _ allowed in exponent
.3e5_F         // invalid; no trailing _ allowed in exponent
*/

// decimal, hex e bin validos
123
10_543_765Lu
1_2__3___4____5
_123
0xFf
0X1b_a0_44_fEL
0x1ade_3FE1_29AaUL
0x_abc
_0x123
0b101
0B1001_1010u
0b1111_1111_0000UL
0B__111
__0B111

// reais literais validos
3.1456233
0.232354
1.234_567
.3e5f
2_345E-2_0
15D
19.73M


'A'
'f'
