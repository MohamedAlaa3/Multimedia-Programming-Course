#include <iostream>
#include <conio.h>
using namespace std;
int ch = 0;
void Disp(char x[][80])
{
	system("cls");
	int r, c, i, k, q = 1, a = 0, b = 49;
	for (r = 0; r < 24; r++)
	{
		/*if (r == 0)
		{
			for (c = 0; c < 80; c++)
			{
				cout << a;
				a++;
				if (a == 10)
				{
					a = 0;
					x[1][c + 1] = b;
					b++;
				}
			}
		}*/
		/*else
		{*/
		for (c = 0; c < 80; c++)
		{
			/*if (c == 0&&r>0)
			{

				cout << q;
				q++;
				if (q == 10)
				{
					q = 0;
				}
			}
			else*/
			cout << x[r][c];
		}
	}
}

//}

void GameOver(char x[][80])
{
	int r, c, i, k;
	for (r = 0; r < 24; r++)
	{
		for (c = 0; c < 80; c++)
		{
			x[r][c] = 176;
		}
	}
	x[12][30] = 'G';
	x[12][31] = 'a';
	x[12][32] = 'm';
	x[12][33] = 'e';
	x[12][34] = ' ';
	x[12][35] = 'O';
	x[12][36] = 'v';
	x[12][37] = 'e';
	x[12][38] = 'r';
	Disp(x);
}

int des = 0, des1 = 0, des2 = 0, des3 = 0, des4 = 0, des5 = 0, des6 = 0, des7 = 0, des8 = 0, des9 = 0, des10 = 0;
void FillX(char x[][80], int y[], int a, int rc[], int rr[], int rd[], int m[])
{

	// Design all static Objects
	int r, c, i, k;
	for (r = 1; r < 24; r++)
	{
		for (c = 0; c < 80; c++)
		{
			x[r][c] = 176;
		}
	}
	x[0][23] = '1';
	x[0][24] = 76;
	x[0][25] = 105;
	x[0][26] = 118;
	x[0][27] = 101;
	x[0][28] = 115;
	x[0][34] = ' ';
	x[0][35] = 'T';
	x[0][36] = 'i';
	x[0][37] = 'm';
	x[0][38] = 'e';
	x[0][39] = ' ';
	x[0][41] = ':';

	x[0][44] = ' ';
	x[0][50] = 80;
	x[0][51] = 111;
	x[0][52] = 105;
	x[0][53] = 110;
	x[0][54] = 116;
	x[0][55] = 115;
	x[0][56] = 58;



	for (r = 1; r < 7; r += 6)
	{
		for (c = 0; c < 80; c++)
		{
			x[r][c] = 178;
		}
	}
	for (r = 9; r < 16; r += 7)
	{
		for (c = 0; c < 51; c++)
		{
			x[r][c] = 178;
		}
	}
	r = 15;
	for (c = 5; c < 25; c++)
	{
		x[r][c] = 178;
	}
	c = 5;
	for (r = 11; r < 16; r++)
	{
		x[r][c] = 178;
	}
	for (r = 17; r < 25; r += 8)
	{
		for (c = 26; c < 80; c++)
		{
			x[r][c] = 178;
		}
	}
	r = 15;
	for (c = 30; c < 44; c++)
	{
		x[r][c] = 178;
	}
	c = 35;
	for (r = 11; r < 14; r++)
	{
		x[r][c] = 178;
	}
	c = 36;
	for (r = 11; r < 14; r++)
	{
		x[r][c] = 178;
	}
	c = 58;
	for (r = 19; r < 22; r++)
	{
		x[r][c] = 178;
	}
	c = 59;
	for (r = 19; r < 22; r++)
	{
		x[r][c] = 178;
	}
	for (c = 0; c < 52; c += 25)
	{
		for (r = 1; r < 24; r++)
		{
			x[r][c] = 178;

		}
	}
	x[7][25] = ' ';
	x[3][50] = ' ';
	x[12][25] = ' ';
	x[15][50] = ' ';
	x[18][25] = ' ';
	x[22][50] = ' ';
	for (c = 50; c < 80; c += 29)
	{
		for (r = 1; r < 24; r++)
		{
			x[r][c] = 178;
		}
	}
	for (r = 23; r < 24; r++)
	{
		for (c = 0; c < 80; c++)
		{
			x[r][c] = 178;
		}
	}
	x[3][50] = ' ';
	x[15][50] = ' ';
	x[22][50] = ' ';
	//enemy
	for (i = 2; i < 5; i++)
	{
		for (k = 11; k < 25; k++)
		{
			x[i][k] = ' ';

		}
	}
	for (i = 4; i < 6; i++)
	{
		for (k = 30; k < 45; k++)
		{
			x[i][k] = ' ';

		}
	}
	for (i = 6; i < 17; i++)
	{
		for (k = 56; k < 76; k++)
		{
			x[i][k] = ' ';

		}
	}
	for (i = 12; i < 14; i++)
	{
		for (k = 8; k < 21; k++)
		{
			x[i][k] = ' ';

		}
	}
	for (i = 19; i < 22; i++)
	{
		for (k = 2; k < 20; k++)
		{
			x[i][k] = ' ';

		}
	}
	for (i = 21; i < 22; i++)
	{
		for (k = 32; k < 45; k++)
		{
			x[i][k] = ' ';

		}
	}
	for (i = 19; i < 22; i++)
	{
		for (k = 69; k < 78; k++)
		{
			x[i][k] = ' ';

		}
	}
	for (i = 0; i < a; i += 2)//space before hero
	{
		x[y[i]][y[i + 1]] = ' ';
	}
	int b = 0;
	for (int o = 0; o < 220; o += 2)
	{
		if (!rd[b])
		{
			x[rc[o]][rc[o + 1]] = 169;
		}
		b++;
	}
	for (int p = 0; p < 220; p += 2)//spaec
	{
		if (x[rr[p]][rr[p + 1]] != char(169) && x[rr[p]][rr[p + 1]] != char(223) && x[rr[p]][rr[p + 1]] != char(219) && x[rr[p]][rr[p + 1]] != char(229))
		{
			x[rr[p]][rr[p + 1]] = ' ';
		}
	}




}

void FillRock(char x[][80], int& r, int& c)
{
	x[r][c] = 169;
}


int l2 = -5;
int a2 = -5;


void MoveRock(char x[][80], int& r, int& c, char& Q, int l, int a)
{


	if (x[r][c] == char(169) && (x[r + 1][c] == ' ' || x[r + 1][c] == char(223)))
	{
		/*if (x[r + 1][c] == char(223)&&ch )
		{
			l2 = l;
			a2 = a;
			ch = 0;
		}*/



		if (x[r + 1][c] == char(223) && a2 + 6 == a && l2 == l)
		{
			r++;
			Q = 'k';
			a2 = a;
		}
		if (x[r + 1][c] == ' ')
			r++;
		if (x[r + 1][c] == char(223) && Q == 's' && ch)
		{
			a2 = a;
			l2 = l;
		}

		/* if (x[r + 1][c] == char(223) && Q == 's')
		 {


		 }*/




	}
	if (x[r][c] == char(169) && x[r + 1][c] == char(178) && x[r][c - 1] == ' ' && x[r + 1][c - 1] == ' ')
	{
		c--;
	}
	if (x[r][c] == char(169) && x[r + 1][c] == char(178) && x[r][c + 1] == ' ' && x[r + 1][c + 1] == ' ')
	{
		c++;
	}
	if (x[r][c] == char(169) && x[r + 1][c] == char(169) && x[r][c - 1] == ' ' && x[r + 1][c - 1] == ' ')
	{
		c--;
	}
	if (x[r][c] == char(169) && x[r + 1][c] == char(169) && x[r][c + 1] == ' ' && x[r + 1][c + 1] == ' ')
	{
		c++;
	}

}
void fillD(char x[][80], int dy[], int du[])
{
	int i;
	for (i = 0; i < 58; i += 2)
	{
		x[dy[i]][dy[i + 1]] = 229;
	}
	for (int p = 0; p < 58; p += 2)//space
	{
		if (x[du[p]][du[p + 1]] != char(229) && x[du[p]][du[p + 1]] != char(223) && x[du[p]][du[p + 1]] != char(219) && x[du[p]][du[p + 1]] != char(169))
		{
			x[du[p]][du[p + 1]] = ' ';
		}
	}
}


void MoveD(char x[][80], int& r, int& c, int y)
{
	if (x[r][c] == char(y) && x[r + 1][c] == ' ')
	{
		r++;
	}
	if (x[r][c] == char(y) && x[r + 1][c] == char(178) && x[r][c - 1] == ' ' && x[r + 1][c - 1] == ' ')
	{
		c--;
	}
	if (x[r][c] == char(y) && x[r + 1][c] == char(178) && x[r][c + 1] == ' ' && x[r + 1][c + 1] == ' ')
	{
		c++;
	}
	if (x[r][c] == char(y) && (x[r + 1][c] == char(169) || x[r + 1][c] == char(229)) && x[r][c - 1] == ' ' && x[r + 1][c - 1] == ' ')
	{
		c--;
	}
	if (x[r][c] == char(y) && (x[r + 1][c] == char(169) || x[r + 1][c] == char(229)) && x[r][c + 1] == ' ' && x[r + 1][c + 1] == ' ')
	{
		c++;
	}
}

void RockDes(char x[][80], int& p, int& b, int& re, int& ce, int& rd, int& t, int& s)
{
	if (x[p][b] == char(169) && x[p - 1][b] == char(219) && x[p + 1][b] == ' ')
	{
		x[p][b] = 42;
		x[p + 1][b] = 42;
		x[p + 1][b + 1] = 42;
		x[p + 1][b - 1] = 42;
		x[p][b + 1] = 42;
		x[p][b - 1] = 42;
		x[p - 1][b - 1] = 42;
		x[p - 1][b] = 42;
		x[p - 1][b + 1] = 42;
		rd = 1;
	}
	if (p == re && b == ce)
	{
		x[p][b] = 42;
		x[p + 1][b] = 42;
		x[p + 1][b + 1] = 42;
		x[p + 1][b - 1] = 42;
		x[p][b + 1] = 42;
		x[p][b - 1] = 42;
		x[p - 1][b - 1] = 42;
		x[p - 1][b] = 42;
		x[p - 1][b + 1] = 42;
		rd = 1;
	}
	if ((x[p][b] == char(169) && x[p + 1][b] == char(219)))
	{

		x[p][b] = 42;
		x[p + 1][b] = 42;
		x[p + 1][b + 1] = 42;
		x[p + 1][b - 1] = 42;
		x[p][b + 1] = 42;
		x[p][b - 1] = 42;
		x[p - 1][b - 1] = 42;
		x[p - 1][b] = 42;
		x[p - 1][b + 1] = 42;
		rd = 1;
	}
	if (rd == 1)
	{
		t = p;
		s = b;
	}
}
void FillDes(char X[][80], int& p, int& b)
{

	X[p][b] = ' ';
	X[p + 1][b] = ' ';
	X[p + 1][b + 1] = ' ';
	X[p + 1][b - 1] = ' ';
	X[p][b + 1] = ' ';
	X[p][b - 1] = ' ';
	X[p - 1][b - 1] = ' ';
	X[p - 1][b] = ' ';
	X[p - 1][b + 1] = ' ';

}


void FillEnemyInX(char x[][80], int rE, int cE)
{
	x[rE][cE] = 219;

}
void MoveEnemyPosition(int& re, int& ce, int hr, int hc, char x[][80], int& r, int& c)
{
	int v = 0;
	for (int i = re; i <= 24; i++)//search for hero (r down) (1)
	{
		if (x[i][ce] != ' ')
		{
			if (x[i][ce] == char(223))
				v = 1;
			break;
		}

	}
	for (int i = re; i >= 0; i--)//search for hero (r up) (2)
	{
		if (x[i][ce] != ' ')
		{
			if (x[i][ce] == char(223))
				v = 2;
			break;
		}

	}
	for (int i = ce; i <= 80; i++)//search for hero (c right) (3)
	{
		if (x[re][i] != ' ')
		{
			if (x[re][i] == char(223))
				v = 3;
			break;
		}

	}
	for (int i = ce; i >= 0; i--)//search for hero (c left) (4)
	{
		if (x[re][i] != ' ')
		{
			if (x[re][i] == char(223))
			{
				v = 4;
			}
			break;
		}

	}

	if (v)
	{
		if (v == 1)//down
		{
			re++;
			r = 1;
			c = 0;
		}
		if (v == 2)//up
		{
			re--;
			r = -1;
			c = 0;
		}
		if (v == 3)//right
		{
			ce++;
			c = 1;
			r = 0;
		}
		if (v == 4)//left 
		{
			ce--;
			c = -1;
			r = 0;
		}
	}
	else
	{
		if (x[re + 1][ce] == ' ' || x[re + 1][ce] == char(223))//down
		{
			if ((x[re - 1][ce] == ' ' || x[re - 1][ce] == char(223)) && r == -1)//up
			{
				re--;
				r = -1;
				c = 0;
			}
			else
			{
				if (x[re][ce + 1] == ' ' || x[re][ce + 1] == char(223))//right
				{
					ce++;
					c = 1;
					r = 0;
				}
				else
				{

					r = 1;
					c = 0;
					re++;
				}
			}
		}
		else
		{
			if (x[re][ce - 1] == ' ' || x[re][ce - 1] == char(223))//left
			{
				if ((x[re][ce + 1] == ' ' || x[re][ce + 1] == char(223)) && c == 1)//right
				{
					ce++;
					c = 1;
					r = 0;
				}
				else
				{
					ce--;
					c = -1;
					r = 0;
				}
			}
			else
			{
				if (x[re - 1][ce] == ' ' || x[re - 1][ce] == char(223))//up
				{

					re--;
					r = -1;
					c = 0;
				}
				else
				{
					if (x[re][ce + 1] == ' ' || x[re][ce + 1] == char(223))//right
					{
						if ((x[re][ce - 1] == ' ' || x[re][ce - 1] == char(223)) && c == -1)//left
						{
							ce--;
							c = -1;
							r = 0;
						}
						else
						{
							ce++;
							c = 1;
							r = 0;
						}
					}
				}
			}
		}
	}
}

void FillHeroInX(char x[][80], int rH, int cH)
{
	x[rH][cH] = 223;


}


void MoveHeroPosition(int& rH, int& cH, char Q, char x[][80], int& s1, int dy[])
{
	if (Q == 'a' && (x[rH][cH - 1] == ' ' || x[rH][cH - 1] == char(176) || x[rH][cH - 1] == char(229)) && rH > -1 && rH<25 && cH - 1>-1 && cH - 1 < 81)
	{
		if (x[rH][cH - 1] == char(229))
		{
			s1 += 5;
			for (int i = 0; i < 58; i += 2)
			{
				if (dy[i] == rH && dy[i + 1] == cH - 1)
				{
					dy[i] = -1;
					dy[i + 1] = -1;
				}
			}
		}

		cH--;

	}
	if (Q == 'w' && (x[rH - 1][cH] == ' ' || x[rH - 1][cH] == char(176) || x[rH - 1][cH] == char(229)) && rH - 1 > -1 && rH - 1 < 25 && cH > -1 && cH < 81)
	{
		if (x[rH - 1][cH] == char(229))
		{
			s1 += 5;
			for (int i = 0; i < 58; i += 2)
			{

				if (dy[i] == rH - 1 && dy[i + 1] == cH)
				{
					dy[i] = -1;
					dy[i + 1] = -1;
				}
			}
		}

		rH--;
	}
	if (Q == 's' && (x[rH + 1][cH] == ' ' || x[rH + 1][cH] == char(176) || x[rH + 1][cH] == char(229)) && rH + 1 > -1 && rH + 1 < 25 && cH > -1 && cH < 81)
	{
		if (x[rH + 1][cH] == char(229))
		{
			s1 += 5;
			for (int i = 0; i < 58; i += 2)
			{

				if (dy[i] == rH + 1 && dy[i + 1] == cH)
				{
					dy[i] = -1;
					dy[i + 1] = -1;
				}
			}

		}
		rH++;
		ch = 1;
	}
	if (Q == 'd' && (x[rH][cH + 1] == ' ' || x[rH][cH + 1] == char(176) || x[rH][cH + 1] == char(229)) && rH > -1 && rH< 25 && cH + 1 > -1 && cH + 1 < 81)
	{
		if (x[rH][cH + 1] == char(229))
		{
			s1 += 5;
			for (int i = 0; i < 58; i += 2)
			{

				if (dy[i] == rH && dy[i + 1] == cH + 1)
				{
					dy[i] = -1;
					dy[i + 1] = -1;
				}
			}
		}
		cH++;
	}

}

void FillX2(char x[][80])
{
	// Desgn all static Objects
	int r, c;
	for (r = 0; r < 24; r++)
	{
		for (c = 0; c < 80; c++)
		{
			x[r][c] = ' ';
		}
	}

	for (c = 0; c < 80; c++)
	{
		x[0][c] = 178;
		x[23][c] = 178;

	}
	for (r = 0; r < 24; r++)
	{
		x[r][0] = 178;
		x[r][79] = 178;

	}
	r = 15;
	for (c = 0; c < 80; c++)
	{
		x[r][c] = 178;
	}
	//first stage enemy
	//1
	x[22][11] = 210;

	//2
	x[16][22] = 208;

	//3
	x[22][33] = 210;

	//4
	x[16][44] = 208;

	//5
	x[22][55] = 210;

	//6
	x[16][66] = 208;

	c = 72;
	for (r = 13; r < 20; r++)
	{
		x[r][c] = 186;
		x[r][c + 6] = 186;
	}
	x[15][72] = 178;
	x[15][78] = 178;

	for (r = 13; r < 20; r++)
	{
		for (c = 73; c < 78; c++)
		{
			x[r][c] = 205;
		}
	}



}



void fillenemy2(char x[][80], int re, int ce)
{
	x[re][ce] = 1;
	x[re + 1][ce] = 186;
	x[re + 2][ce] = 186;
	x[re + 3][ce] = 186;
	x[re + 3][ce - 1] = '-';
	x[re + 3][ce - 2] = '-';
	x[re + 3][ce - 3] = '-';
	x[re + 3][ce + 1] = '-';
	x[re + 3][ce + 2] = '-';
	x[re + 3][ce + 3] = '-';
	//x[re + 4][ce] = 186;
	//x[re + 5][ce] = 186;
	x[re + 4][ce - 1] = '/';
	x[re + 5][ce - 2] = '/';
	x[re + 4][ce + 1] = '\\';
	x[re + 5][ce + 2] = '\\';
}

//first stage enemy 
//21
void FillEnmyInX2(char X[][80], int re, int ce)
{
	X[re][ce] = 248;
}

void MoveEnmyPositiondown2(int& re, int& ce)
{
	if (re > 16)
	{
		re--;
	}
	else
	{
		re = 21;
	}
}

void MoveEnmyPositionup2(int& re, int& ce)
{
	if (re < 22)
	{
		re++;
	}
	else
	{
		re = 17;
	}
}


void MoveHeroPosition2(int& rh, int& ch, char Q, int g)
{
	if (Q == 'a')
	{
		ch--;
	}
	if (Q == 'd')
	{
		ch++;
	}
	if (g)
	{
		if (Q == 'w')
		{
			rh -= 2;
		}
		if (Q == 's')
		{
			rh++;
		}

	}
	if (rh == 19 && ch == 73 || rh == 19 && ch == 74 || rh == 19 && ch == 75 || rh == 19 && ch == 76 || rh == 19 && ch == 77)
	{
		rh = 13;
		ch = 75;
	}

}


void movebullet2(char x[][80], int b[], int& b1, int& h)
{
	int i, k;
	for (i = 0; i < b1; i += 2)
	{
		if (b[i + 1] > 2 && x[b[i]][b[i + 1]] == ' ')
			b[i + 1]--;
		else
		{
			if (x[b[i]][b[i + 1]] != ' ' && x[b[i]][b[i + 1]] != 219)
			{
				h--;
			}
			for (k = i; k < b1 - 2; k++)
			{
				b[k] = b[k + 2];
			}
			b1 -= 2;
		}
	}
}
void fillbullet2(char x[][80], int b[], int& b1)
{
	int i;
	for (i = 0; i < b1; i += 2)
	{

		x[b[i]][b[i + 1]] = 174;
	}
}

void enmybullet2(char x[][80], int re, int ce, int rh, int eb[], int& e, int a, int& h2)
{


	int i, k;
	for (i = 0; i < e; i += 2)
	{
		if (eb[i + 1] < 79 && x[eb[i]][eb[i + 1]] == ' ')
			eb[i + 1]++;
		else
		{
			if (x[eb[i]][eb[i + 1]] != ' ' && x[eb[i]][eb[i + 1]] != 254)
			{
				h2--;
			}
			for (k = i; k < e - 2; k++)
			{
				eb[k] = eb[k + 2];
			}
			e -= 2;
		}
	}

	if (re <= rh && re + 6 >= rh && a % 15 == 0)
	{
		eb[e] = rh;
		eb[e + 1] = ce + 2;
		e += 2;

	}
	for (i = 0; i < e; i += 2)
	{

		x[eb[i]][eb[i + 1]] = 219;
	}
}
void enemyhelth2(char x[][80], int& i)
{

	int k;
	for (k = 3; k < i + 3; k++)
	{
		x[2][k] = 219;
	}
	if (i == 10)
	{
		x[2][k + 1] = 49;
		x[2][k + 2] = 48;
		x[2][k + 3] = 48;
	}
	else
	{
		x[2][k + 1] = 48 + i;
		x[2][k + 2] = 48;
	}


}
void moveenmy22(int& re, int& z)
{
	if (re == 3)
	{
		z = 1;
	}
	if (re == 7)
	{
		z = -1;
	}
	if (z == -1)
	{
		re--;
		z = -1;
	}

	if (z == 1)
	{
		re++;
		z = 1;
	}
}
void FillHeroInX2(char x[][80], int rh, int ch, int g, int r)
{
	if (!g)
	{
		x[rh][ch] = 219;
		x[rh][ch + 1] = 219;
		x[rh][ch - 1] = 219;
		x[rh + 1][ch - 1] = 217;
		x[rh + 1][ch + 1] = 192;
	}
	else
	{
		if (r % 2 == 0)
		{
			x[rh][ch] = 219;
			x[rh][ch + 1] = 219;
			x[rh][ch - 1] = 219;
			x[rh + 1][ch - 1] = 217;
			x[rh + 1][ch + 1] = 192;
			x[rh - 1][ch] = 194;
			x[rh - 1][ch + 1] = 196;
			x[rh - 1][ch - 1] = 196;
		}
		if (r % 2 != 0 && x[rh + 2][ch] != char(178))
		{
			x[rh][ch] = 219;
			x[rh][ch + 1] = 219;
			x[rh][ch - 1] = 219;
			x[rh + 1][ch - 1] = 217;
			x[rh + 1][ch + 1] = 192;
			x[rh - 1][ch] = 179;
		}
	}
}
void FillChopper2(char x[][80], int cr, int cc)
{
	x[cr][cc] = 254;
	x[cr - 1][cc] = 194;
	x[cr - 1][cc + 1] = 196;
	x[cr - 1][cc - 1] = 196;
}
void FillX3(char x[][80])
{
	// Desgn all static Objects
	int r, c;
	for (r = 0; r < 24; r++)
	{
		for (c = 0; c < 80; c++)
		{
			x[r][c] = ' ';
		}
	}

	for (c = 0; c < 80; c++)
	{
		x[0][c] = 178;
		x[23][c] = 178;
	}
	for (c = 1; c < 20; c++)
	{
		x[23][c] = 47;
		x[22][c] = 47;
	}
	for (r = 0; r < 24; r++)
	{
		x[r][0] = 178;
		x[r][79] = 178;
	}

	for (c = 20; c < 60; c++)
	{
		x[7][c] = 178;
	}
	for (r = 8; r < 24; r++)
	{
		x[r][20] = 178;
	}
	for (r = 4; r < 21; r += 2)
	{
		x[r][10] = 186;
	}
	for (c = 13; c < 70; c++)
	{
		x[3][c] = 205;
	}
	for (c = 9; c < 70; c += 4)
	{
		x[3][c] = ' ';
		x[3][c + 1] = ' ';
		x[3][c + 2] = ' ';
		c += 2;
	}
	for (r = 7; r < 17; r++)
	{
		x[r][60] = 178;
	}
	for (c = 35; c < 61; c++)
	{
		x[17][c] = 178;
	}
	for (r = 4; r < 21; r += 2)
	{
		x[r][70] = 186;
	}
	for (c = 25; c < 70; c++)
	{
		x[21][c] = 205;
	}
	for (c = 25; c < 70; c += 4)
	{
		x[21][c] = ' ';
		x[21][c + 1] = ' ';
		x[21][c + 2] = ' ';
		c += 2;
	}
	for (r = 11; r < 20; r += 2)
	{
		x[r][27] = 186;
	}
	for (r = 8; r < 17; r += 2)
	{
		for (c = 35; c < 60; c++)
		{
			x[r][c] = 47;
		}
	}


}
void MoveHeroPosition3(int& rh, int& ch, char Q)
{
	if (Q == 'a')
	{
		ch--;
	}
	if (Q == 'w')
	{
		rh--;
	}
	if (Q == 's')
	{
		rh++;
	}
	if (Q == 'd')
	{
		ch++;
	}
}
void FillHeroInX3(char x[][80], int rh, int ch, int u, int m)
{
	if (!u)
	{
		x[rh][ch] = 219;
		x[rh][ch + 1] = 219;
		x[rh][ch - 1] = 219;
		x[rh + 1][ch - 1] = 217;
		x[rh + 1][ch + 1] = 192;
	}
	int car = rh - 3;
	int cac = ch;
	if (u)
	{
		if (m == 0)
		{
			x[car + 1][cac] = 219;
			x[car + 1][cac + 1] = 219;
			x[car + 1][cac - 1] = 219;
			x[car][cac] = 169;
			x[car - 1][cac] = 205;
			x[car - 1][cac + 1] = 205;
			x[car - 1][cac - 1] = 205;
			x[car - 1][cac + 3] = 184;
			x[car - 1][cac + 2] = 188;
			x[car - 1][cac - 2] = 200;
			x[car - 2][cac + 2] = 187;
			x[car - 2][cac - 2] = 201;
			x[car - 2][cac] = 205;
			x[car - 2][cac + 1] = 205;
			x[car - 2][cac - 1] = 205;
			x[car][cac + 2] = 186;
			x[car][cac - 2] = 186;
			x[car + 1][cac + 2] = 186;
			x[car + 1][cac - 2] = 186;
			x[car + 2][cac + 3] = 184;
			x[car + 2][cac + 2] = 187;
			x[car + 2][cac - 2] = 201;
			x[car + 2][cac] = 205;
			x[car + 2][cac + 1] = 205;
			x[car + 2][cac - 1] = 205;
			x[car + 3][cac + 2] = 188;
			x[car + 3][cac - 2] = 200;
			x[car + 3][cac] = 205;
			x[car + 3][cac + 1] = 205;
			x[car + 3][cac - 1] = 205;
		}
		if (m == 1)
		{
			x[car][cac - 1] = 219;
			x[car][cac - 2] = 219;
			x[car][cac] = 169;
			x[car][cac + 1] = 186;
			x[car - 1][cac + 1] = 201;
			x[car + 1][cac + 1] = 200;
			x[car + 1][cac + 2] = 205;
			x[car - 1][cac + 2] = 205;
			x[car + 1][cac + 3] = 188;
			x[car - 1][cac + 3] = 187;
			x[car][cac + 3] = 186;
			x[car + 1][cac] = 205;
			x[car - 1][cac] = 205;
			x[car + 1][cac - 1] = 205;
			x[car - 1][cac - 1] = 205;
			x[car + 1][cac - 2] = 205;
			x[car - 1][cac - 2] = 205;
			x[car][cac - 5] = 186;
			x[car][cac - 3] = 186;
			x[car - 1][cac - 5] = 201;
			x[car + 1][cac - 5] = 200;
			x[car + 1][cac - 4] = 205;
			x[car - 1][cac - 4] = 205;
			x[car + 1][cac - 3] = 188;
			x[car - 1][cac - 3] = 187;
		}
		if (m == 2)
		{
			x[car][cac] = 219;
			x[car][cac + 1] = 219;
			x[car][cac - 1] = 219;
			x[car + 1][cac] = 169;
			x[car - 1][cac] = 205;
			x[car - 1][cac + 1] = 205;
			x[car - 1][cac - 1] = 205;
			x[car - 1][cac + 3] = 184;
			x[car - 1][cac + 2] = 188;
			x[car - 1][cac - 2] = 200;
			x[car - 2][cac + 2] = 187;
			x[car - 2][cac - 2] = 201;
			x[car - 2][cac] = 205;
			x[car - 2][cac + 1] = 205;
			x[car - 2][cac - 1] = 205;
			x[car][cac + 2] = 186;
			x[car][cac - 2] = 186;
			x[car + 1][cac + 2] = 186;
			x[car + 1][cac - 2] = 186;
			x[car + 2][cac + 3] = 184;
			x[car + 2][cac + 2] = 187;
			x[car + 2][cac - 2] = 201;
			x[car + 2][cac] = 205;
			x[car + 2][cac + 1] = 205;
			x[car + 2][cac - 1] = 205;
			x[car + 3][cac + 2] = 188;
			x[car + 3][cac - 2] = 200;
			x[car + 3][cac] = 205;
			x[car + 3][cac + 1] = 205;
			x[car + 3][cac - 1] = 205;
		}
		if (m == 3)
		{
			x[car][cac] = 219;
			x[car][cac - 1] = 219;
			x[car][cac - 2] = 169;
			x[car][cac + 1] = 186;
			x[car - 1][cac + 1] = 201;
			x[car + 1][cac + 1] = 200;
			x[car + 1][cac + 2] = 205;
			x[car - 1][cac + 2] = 205;
			x[car + 1][cac + 3] = 188;
			x[car - 1][cac + 3] = 187;
			x[car][cac + 3] = 186;
			x[car + 1][cac] = 205;
			x[car - 1][cac] = 205;
			x[car + 1][cac - 1] = 205;
			x[car - 1][cac - 1] = 205;
			x[car + 1][cac - 2] = 205;
			x[car - 1][cac - 2] = 205;
			x[car][cac - 5] = 186;
			x[car][cac - 3] = 186;
			x[car - 1][cac - 5] = 201;
			x[car + 1][cac - 5] = 200;
			x[car + 1][cac - 4] = 205;
			x[car - 1][cac - 4] = 205;
			x[car + 1][cac - 3] = 188;
			x[car - 1][cac - 3] = 187;
		}

	}

}
void FillCar3(char x[][80], int car, int cac)
{
	x[car][cac] = 169;
	x[car - 1][cac] = 205;
	x[car - 1][cac + 1] = 205;
	x[car - 1][cac - 1] = 205;
	x[car - 1][cac + 3] = 184;
	x[car - 1][cac + 2] = 188;
	x[car - 1][cac - 2] = 200;
	x[car - 2][cac + 2] = 187;
	x[car - 2][cac - 2] = 201;
	x[car - 2][cac] = 205;
	x[car - 2][cac + 1] = 205;
	x[car - 2][cac - 1] = 205;
	x[car][cac + 2] = 186;
	x[car][cac - 2] = 186;
	x[car + 1][cac + 2] = 186;
	x[car + 1][cac - 2] = 186;
	x[car + 2][cac + 3] = 184;
	x[car + 2][cac + 2] = 187;
	x[car + 2][cac - 2] = 201;
	x[car + 2][cac] = 205;
	x[car + 2][cac + 1] = 205;
	x[car + 2][cac - 1] = 205;
	x[car + 3][cac + 2] = 188;
	x[car + 3][cac - 2] = 200;
	x[car + 3][cac] = 205;
	x[car + 3][cac + 1] = 205;
	x[car + 3][cac - 1] = 205;
}
void FillEnemyCar(char x[][80], int car, int cac, int& p)
{
	if (car >= 6 && cac == 15)
	{
		x[car][cac] = 169;
		x[car - 1][cac] = 196;
		x[car - 1][cac + 1] = 196;
		x[car - 1][cac - 1] = 196;
		x[car - 1][cac + 3] = 184;
		x[car - 1][cac + 2] = 217;
		x[car - 1][cac - 2] = 192;
		x[car - 2][cac + 2] = 191;
		x[car - 2][cac - 2] = 218;
		x[car - 2][cac] = 196;
		x[car - 2][cac + 1] = 196;
		x[car - 2][cac - 1] = 196;
		x[car][cac + 2] = 179;
		x[car][cac - 2] = 179;
		x[car + 1][cac + 2] = 179;
		x[car + 1][cac - 2] = 179;
		x[car + 2][cac + 3] = 184;
		x[car + 2][cac + 2] = 191;
		x[car + 2][cac - 2] = 218;
		x[car + 2][cac] = 196;
		x[car + 2][cac + 1] = 196;
		x[car + 2][cac - 1] = 196;
		x[car + 3][cac + 2] = 217;
		x[car + 3][cac - 2] = 192;
		x[car + 3][cac] = 196;
		x[car + 3][cac + 1] = 196;
		x[car + 3][cac - 1] = 196;
		p = 1;
	}
	if (car == 5 && cac <= 66)
	{
		x[car][cac] = 169;
		x[car][cac + 1] = 179;
		x[car - 1][cac + 1] = 218;
		x[car + 1][cac + 1] = 192;
		x[car + 1][cac + 2] = 196;
		x[car - 1][cac + 2] = 196;
		x[car + 1][cac + 3] = 217;
		x[car - 1][cac + 3] = 191;
		x[car][cac + 3] = 179;
		x[car + 1][cac] = 196;
		x[car - 1][cac] = 196;
		x[car + 1][cac - 1] = 196;
		x[car - 1][cac - 1] = 196;
		x[car + 1][cac - 2] = 196;
		x[car - 1][cac - 2] = 196;
		x[car][cac - 5] = 179;
		x[car][cac - 3] = 179;
		x[car - 1][cac - 5] = 218;
		x[car + 1][cac - 5] = 192;
		x[car + 1][cac - 4] = 196;
		x[car - 1][cac - 4] = 196;
		x[car + 1][cac - 3] = 217;
		x[car - 1][cac - 3] = 191;
		p = 4;
	}
	if (car <= 19 && car >= 5 && cac == 67)
	{
		x[car + 1][cac] = 169;
		x[car - 1][cac] = 196;
		x[car - 1][cac + 1] = 196;
		x[car - 1][cac - 1] = 196;
		x[car - 1][cac + 3] = 184;
		x[car - 1][cac + 2] = 217;
		x[car - 1][cac - 2] = 192;
		x[car - 2][cac + 2] = 191;
		x[car - 2][cac - 2] = 218;
		x[car - 2][cac] = 196;
		x[car - 2][cac + 1] = 196;
		x[car - 2][cac - 1] = 196;
		x[car][cac + 2] = 179;
		x[car][cac - 2] = 179;
		x[car + 1][cac + 2] = 179;
		x[car + 1][cac - 2] = 179;
		x[car + 2][cac + 3] = 184;
		x[car + 2][cac + 2] = 191;
		x[car + 2][cac - 2] = 218;
		x[car + 2][cac] = 196;
		x[car + 2][cac + 1] = 196;
		x[car + 2][cac - 1] = 196;
		x[car + 3][cac + 2] = 217;
		x[car + 3][cac - 2] = 192;
		x[car + 3][cac] = 196;
		x[car + 3][cac + 1] = 196;
		x[car + 3][cac - 1] = 196;
		p = 2;
	}
	if (car == 19 && cac <= 67)
	{

		x[car][cac - 2] = 169;
		x[car][cac + 1] = 179;
		x[car - 1][cac + 1] = 218;
		x[car + 1][cac + 1] = 192;
		x[car + 1][cac + 2] = 196;
		x[car - 1][cac + 2] = 196;
		x[car + 1][cac + 3] = 217;
		x[car - 1][cac + 3] = 191;
		x[car][cac + 3] = 179;
		x[car + 1][cac] = 196;
		x[car - 1][cac] = 196;
		x[car + 1][cac - 1] = 196;
		x[car - 1][cac - 1] = 196;
		x[car + 1][cac - 2] = 196;
		x[car - 1][cac - 2] = 196;
		x[car][cac - 5] = 179;
		x[car][cac - 3] = 179;
		x[car - 1][cac - 5] = 218;
		x[car + 1][cac - 5] = 192;
		x[car + 1][cac - 4] = 196;
		x[car - 1][cac - 4] = 196;
		x[car + 1][cac - 3] = 217;
		x[car - 1][cac - 3] = 191;
		p = 3;
	}
	if (car > 10 && car <= 19 && cac == 31)
	{
		x[car][cac] = 169;
		x[car - 1][cac] = 196;
		x[car - 1][cac + 1] = 196;
		x[car - 1][cac - 1] = 196;
		x[car - 1][cac + 3] = 184;
		x[car - 1][cac + 2] = 217;
		x[car - 1][cac - 2] = 192;
		x[car - 2][cac + 2] = 191;
		x[car - 2][cac - 2] = 218;
		x[car - 2][cac] = 196;
		x[car - 2][cac + 1] = 196;
		x[car - 2][cac - 1] = 196;
		x[car][cac + 2] = 179;
		x[car][cac - 2] = 179;
		x[car + 1][cac + 2] = 179;
		x[car + 1][cac - 2] = 179;
		x[car + 2][cac + 3] = 184;
		x[car + 2][cac + 2] = 191;
		x[car + 2][cac - 2] = 218;
		x[car + 2][cac] = 196;
		x[car + 2][cac + 1] = 196;
		x[car + 2][cac - 1] = 196;
		x[car + 3][cac + 2] = 217;
		x[car + 3][cac - 2] = 192;
		x[car + 3][cac] = 196;
		x[car + 3][cac + 1] = 196;
		x[car + 3][cac - 1] = 196;
		p = 1;
	}
	if (car == 13 && cac < 60 && cac >= 31)
	{
		x[car][cac] = 169;
		x[car][cac + 1] = 179;
		x[car - 1][cac + 1] = 218;
		x[car + 1][cac + 1] = 192;
		x[car + 1][cac + 2] = 196;
		x[car - 1][cac + 2] = 196;
		x[car + 1][cac + 3] = 217;
		x[car - 1][cac + 3] = 191;
		x[car][cac + 3] = 179;
		x[car + 1][cac] = 196;
		x[car - 1][cac] = 196;
		x[car + 1][cac - 1] = 196;
		x[car - 1][cac - 1] = 196;
		x[car + 1][cac - 2] = 196;
		x[car - 1][cac - 2] = 196;
		x[car][cac - 5] = 179;
		x[car][cac - 3] = 179;
		x[car - 1][cac - 5] = 218;
		x[car + 1][cac - 5] = 192;
		x[car + 1][cac - 4] = 196;
		x[car - 1][cac - 4] = 196;
		x[car + 1][cac - 3] = 217;
		x[car - 1][cac - 3] = 191;
		p = 4;
	}
}

void MEC(char x[][80], int& r, int& c, int& p)
{
	if (p == 1)
	{
		r--;
	}
	if (p == 2)
	{
		r++;
	}
	if (p == 3)
	{
		c--;
	}
	if (p == 4)
	{
		c++;
	}
}

void main()
{
	int lev;
	cin >> lev;
	//l1

	char Q = ' ';
	char x[25][80];
	char n[24][80];
	//rocks array, each line is a rectangular area in the map
	int rc[220] = { 2, 2, 2, 3, 2, 4, 2, 8, 3, 1, 3, 8, 3, 7, 7, 2, 4, 5, 6, 2, 6, 9, 6, 10, 6, 20, 7, 15, 7, 20, 7, 21, 7, 14, 8, 16, 8, 5, 8, 17, 2, 1, 7, 1, 8, 1, 8, 15,
		2, 26, 2, 27, 2, 28, 2, 31, 2, 49, 3, 26, 3, 49, 4, 26, 6, 26, 6, 36, 8, 40, 2, 48, 8, 30,
		2, 52, 2, 78, 2, 77, 2, 60, 2, 75, 2, 70, 2, 63, 2, 64, 2, 65, 4, 78, 5, 54, 5, 78, 6, 78, 8, 77, 9, 53, 10, 54, 12, 78, 13, 53, 14, 78, 15, 78, 16, 78, 16, 52,
		10, 26, 10, 27, 11, 26, 10, 44, 15, 45, 14, 48, 11, 49, 11, 29, 14, 28, 15, 28, 12, 42, 12, 30,
		16, 3, 16, 5, 16, 7, 17, 9, 17, 11, 16, 13, 16, 15, 16, 17, 16, 19, 16, 21, 22, 24, 10, 24, 10, 23, 10, 2, 14, 24, 22, 2, 22, 23,
		18, 49, 18, 48, 19, 26, 19, 27, 22, 26, 22, 28, 22, 30, 22, 32, 22, 34, 22, 36, 22, 40, 22, 42, 22, 43, 22, 49,
		22, 54, 21, 52, 18, 51, 18, 55, 19, 60, 20, 61, 21, 60, 21, 56 };
	//array for spaces when rocks leave, still done in rectangular area lines
	int rr[220] = { 2, 2, 2, 3, 2, 4, 2, 8, 3, 1, 3, 8, 3, 7, 7, 2, 4, 5, 6, 2, 6, 9, 6, 10, 6, 20, 7, 15, 7, 20, 7, 21, 7, 14, 8, 16, 8, 5, 8, 17, 2, 1, 7, 1, 8, 1, 8, 15,
		2, 26, 2, 27, 2, 28, 2, 31, 2, 49, 3, 26, 3, 49, 4, 26, 6, 26, 6, 36, 8, 40, 2, 48, 8, 30,
		2, 52, 2, 78, 2, 77, 2, 60, 2, 75, 2, 70, 2, 63, 2, 64, 2, 65, 4, 78, 5, 54, 5, 78, 6, 78, 8, 77, 9, 53, 10, 54, 12, 78, 13, 53, 14, 78, 15, 78, 16, 78, 16, 52,
		10, 26, 10, 27, 11, 26, 10, 44, 15, 45, 14, 48, 11, 49, 11, 29, 14, 28, 15, 28, 12, 42, 12, 30,
		16, 3, 16, 5, 16, 7, 17, 9, 17, 11, 16, 13, 16, 15, 16, 17, 16, 19, 16, 21, 22, 24, 10, 24, 10, 23, 10, 2, 14, 24, 22, 2, 22, 23,
		18, 49, 18, 48, 19, 26, 19, 27, 22, 26, 22, 28, 22, 30, 22, 32, 22, 34, 22, 36, 22, 40, 22, 42, 22, 43, 22, 49,
		22, 54, 21, 52, 18, 51, 18, 55, 19, 60, 20, 61, 21, 60, 21, 56 };
	//rocks destroyed
	int rd[110];
	for (int w = 0; w < 110; w++)
	{
		rd[w] = 0;
	}
	//220 , 254,
	int dy[58] = { 6,5,4,10,3,15,6,36,4,32,3,49,2,55,15,56,14,36,14,35,10,35,10,36,14,20,10,5,14,7,14,8,14,9,14,10,14,11,18,2,19,2,20,2,19,26,20,26,22,36,22,37,22,38,20,60,20,78 };
	//space
	int du[58] = { 6,5,4,10,3,15,6,36,4,32,3,49,2,55,15,56,14,36,14,35,10,35,10,36,14,20,10,5,14,7,14,8,14,9,14,10,14,11,18,2,19,2,20,2,19,26,20,26,22,36,22,37,22,38,20,60,20,78 };

	int rH = 4;
	int cH = 1, a = 0;
	int r = 0, c = 0;
	int y[9999], i = 0;
	int z = 0, o = 0;
	int t = 0, s = 0;

	int re1 = 4, ce1 = 44;
	int re2 = 6, ce2 = 75, z2 = 0, o2 = 0, p = -2;
	int re3 = 11, ce3 = 20, z3 = 0, o3 = 0;
	int re4 = 19, ce4 = 19, z4 = 0, o4 = 0;
	int re5 = 21, ce5 = 44, z5 = 0, o5 = 0;
	int re6 = 19, ce6 = 77, z6 = 0, o6 = 0;
	int re7 = 2, ce7 = 24, z7 = 0, o7 = 0;
	int re8 = 16, ce8 = 57, z8 = 0, o8 = 0;
	int g;
	int j = 0;
	int g1 = 0, g2 = 0, g3 = 0, g4 = 0, g5 = 0, g6 = 0, g7 = 0;
	int min = 48, sec = 49, sec2 = 48;
	int s1 = 48, s2 = 48, s3 = 48, s4 = 48;
	x[0][57] = 48;
	x[0][58] = 48;
	x[0][59] = 48;
	x[0][60] = 48;
	a = 0;
	int l9;
	if (lev == 1)
	{
		for (l9 = 0;; l9++)
		{

			for (; !_kbhit();)
			{
				g = 0;
				FillX(x, y, i, rc, rr, rd, dy);
				for (int w = 0; w < 110; w++)
				{
					if (rd[w])
					{
						FillDes(x, t, s);
					}
				}
				//MoveHeroPosition( rH, cH);
				FillHeroInX(x, rH, cH);
				fillD(x, dy, du);
				if (a % 3 == 0)
				{
					MoveEnemyPosition(re1, ce1, rH, cH, x, z, o);
					MoveEnemyPosition(re2, ce2, rH, cH, x, z2, o2);
					MoveEnemyPosition(re3, ce3, rH, cH, x, z3, o3);
					MoveEnemyPosition(re4, ce4, rH, cH, x, z4, o4);
					MoveEnemyPosition(re5, ce5, rH, cH, x, z5, o5);
					MoveEnemyPosition(re6, ce6, rH, cH, x, z6, o6);
					MoveEnemyPosition(re7, ce7, rH, cH, x, z7, o7);
					MoveEnemyPosition(re8, ce8, rH, cH, x, z8, o8);

				}

				for (int w = 0; w < 58; w += 2)
				{
					if (dy[w] > -1)
					{
						MoveD(x, dy[w], dy[w + 1], 229);
					}
				}

				for (int w = 0; w < 220; w += 2)
				{
					j = w + 1;
					MoveRock(x, rc[w], rc[j], Q, l9, a);
					if (!rd[g])
					{
						if (g < 24)
						{
							RockDes(x, rc[w], rc[j], re7, ce7, rd[g], t, s);
						}
						if (g > 23 && g < 37)
						{
							RockDes(x, rc[w], rc[j], re1, ce1, rd[g], t, s);
						}
						if (g > 36 && g < 59)
						{
							RockDes(x, rc[w], rc[j], re2, ce2, rd[g], t, s);
						}
						if (g > 58 && g < 71)
						{
							RockDes(x, rc[w], rc[j], re2, ce2, rd[g], t, s);
						}
						if (g > 70 && g < 88)
						{
							RockDes(x, rc[w], rc[j], re3, ce3, rd[g], t, s);
							RockDes(x, rc[w], rc[j], re4, ce4, rd[g], t, s);
						}
						if (g > 87 && g < 102)
						{
							RockDes(x, rc[w], rc[j], re5, ce5, rd[g], t, s);
						}
						if (g > 101 && g < 110)
						{
							RockDes(x, rc[w], rc[j], re6, ce6, rd[g], t, s);
						}
					}
					g++;
				}

				for (int w = 0; w < 110; w++)
				{
					if (w < 24)
					{
						if (!rd[w] && !g1)
						{
							FillEnemyInX(x, re7, ce7);
						}
						else
						{
							g1++;
						}
					}
					if (w > 23 && w < 37)
					{
						if (!rd[w] && !g2)
						{
							FillEnemyInX(x, re1, ce1);
						}
						else
						{
							g2++;
						}
					}
					if (w > 36 && w < 71)
					{
						if (!rd[w] && !g3)
						{
							FillEnemyInX(x, re2, ce2);
						}
						else
						{
							g3++;
						}
					}
					if (w > 70 && w < 88)
					{
						if (!rd[w] && !g4)
						{
							FillEnemyInX(x, re3, ce3);
							FillEnemyInX(x, re4, ce4);
						}
						else
						{
							g4++;
						}
						if (!rd[w] && !g5)
						{
							FillEnemyInX(x, re4, ce4);
						}
						else
						{
							g5++;
						}
					}
					if (w > 87 && w < 102)
					{
						if (!rd[w] && !g6)
						{
							FillEnemyInX(x, re5, ce5);
						}
						else
						{
							g6++;
						}
					}
					if (w > 101 && w < 110)
					{
						if (!rd[w] && !g7)
						{
							FillEnemyInX(x, re6, ce6);
						}
						else
						{
							g7++;
						}
					}
				}
				x[0][40] = min;//min

				x[0][42] = sec2;//sec (10)
				x[0][43] = sec;// sec 01
				if (s1 == 58)
				{
					s1 = 48;
					s2++;
				}
				if (s2 == 58)
				{
					s2 = 48;
					s3++;

				}
				if (s3 == 58)
				{
					s3 = 48;
					s4++;
				}
				x[0][57] = s4;
				x[0][58] = s3;
				x[0][59] = s2;
				x[0][60] = s1;

				if (x[0][60] == 53 && x[0][59] == 52 && x[0][58] == 49)
				{
					break;
				}

				Disp(x);



				if (a % 5 == 0)
				{
					sec++;
					if (sec2 == 53 && sec == 58)
					{
						min++;

						sec2 = 47;
					}
					if (sec == 58)
					{
						sec = '0';
						sec2++;
					}
				}
				if (x[rH][cH] == char(219))
				{
					p = a;
					for (int l = 0; l < 7; l++)
						GameOver(n);
				}
				if (a == p || Q == 'k')
				{
					Disp(x);
					break;
				}
				a++;
				Q = ' ';
			}

			if (x[0][60] == 53 && x[0][59] == 52 && x[0][58] == 49)
			{
				cout << "congratulations" << endl;
				cout << "you win";
				break;
			}
			if (x[rH][cH] == char(219) || Q == 'k')
			{
				cout << "Game over";
				break;
			}

			Q = ' ';
			Q = _getch();	// cin>>Q;
			y[i] = rH;
			y[i + 1] = cH;
			i += 2;
			ch = 0;
			MoveHeroPosition(rH, cH, Q, x, s1, dy);


		}
	}




	//l2
	g = 0;
	int cr = 14, cc = 70;
	r = 1;

	int re = 6, ce = 5;
	int a2 = 0;
	int rh = 21, ch = 5;

	re1 = 21;
	ce1 = 11;
	re2 = 16;
	ce2 = 22;
	re3 = 21;
	ce3 = 33;
	re4 = 16;
	ce4 = 44;
	re5 = 21;
	ce5 = 55;
	re6 = 16;
	ce6 = 66;


	int m = 0;
	int b[1000], b1 = 0;
	int eb[1000], e = 0;
	z = -1;
	int h = 10;
	int h2 = 2;
	int k = 0;

	if (lev == 2)
	{
		for (int a = 0;;)
		{
			for (; !_kbhit(); a++)
			{


				FillX2(x);

				//MoveHeroPosition( rh, ch);
				//FillHeroInX(x, rh, ch,g,r);

				if (a % 10 == 0)
				{
					MoveEnmyPositiondown2(re1, ce1);
					MoveEnmyPositionup2(re2, ce2);
					MoveEnmyPositiondown2(re3, ce3);
					MoveEnmyPositionup2(re4, ce4);
					MoveEnmyPositiondown2(re5, ce5);
					MoveEnmyPositionup2(re6, ce6);
				}
				FillEnmyInX2(x, re1, ce1);
				FillEnmyInX2(x, re2, ce2);
				FillEnmyInX2(x, re3, ce3);
				FillEnmyInX2(x, re4, ce4);
				FillEnmyInX2(x, re5, ce5);
				FillEnmyInX2(x, re6, ce6);


				fillenemy2(x, re, ce);
				enmybullet2(x, re, ce, rh, eb, e, a, h2);
				if (a % 5 == 0)
				{
					moveenmy22(re, z);
				}

				enemyhelth2(x, h);






				movebullet2(x, b, b1, h);
				fillbullet2(x, b, b1);
				FillHeroInX2(x, rh, ch, g, r);
				if (!g)
				{
					FillChopper2(x, cr, cc);
				}
				else
				{
					r++;
				}
				if (rh == (cr - 1) && ch == (cc + 2))
				{
					g++;
				}

				if (k)
				{
					if (a == a2)
					{
						rh -= 2;
					}
					if (a == a2 + 1)
					{
						rh -= 2;
					}
					if (a == a2 + 2)
					{
						if (x[rh + 2][ch] == ' ')
							rh++;
					}
					if (a == a2 + 3)
					{
						if (x[rh + 2][ch] == ' ')
							rh++;
						k = 0;
						a2 = 0;
					}
				}
				if (x[rh + 2][ch] == ' ' && a > a2 + 1)
					rh++;

				Disp(x);

			}


			Q = _getch();	// cin>>Q;
			if (Q == ' ')
			{


				b[b1] = rh + 1;
				b[b1 + 1] = ch - 2;
				b1 += 2;


			}
			if (Q == 'k' && !a2)
			{

				a2 = a;
				k = 1;
			}
			MoveHeroPosition2(rh, ch, Q, g);
		}
		p = 1;

		Q = ' ';
		rh = 23;
		ch = 5;
		p = 1;
		int ecar = 17, ecac = 15;
		int car = 17, cac = 5;
		m = 0;
		int u = 0;
		for (int a = 0;;)
		{
			for (; !_kbhit(); a++)
			{


				FillX3(x);
				if (!u)
				{
					FillCar3(x, car, cac);
				}
				if (rh == (car + 3) && ch == cac)
				{
					u++;
				}

				if (x[ecar][ecac + 3] != char(178))
				{
					FillEnemyCar(x, ecar, ecac, p);
					MEC(x, ecar, ecac, p);
				}


				FillHeroInX3(x, rh, ch, u, m);


				Disp(x);


			}
			Q = _getch();	// cin>>Q;
			if (Q == 'e')
			{
				m++;
				if (m == 4)
				{
					m = 0;
				}
			}
			MoveHeroPosition3(rh, ch, Q);

		}
	}
	p = 1;

	Q = ' ';
	rh = 23;
	ch = 5;
	p = 1;
	int ecar = 17, ecac = 15;
	int car = 17, cac = 5;
	m = 0;
	int u = 0;
	if (lev == 3)
	{
		for (int a = 0;;)
		{
			for (; !_kbhit(); a++)
			{


				FillX3(x);
				if (!u)
				{
					FillCar3(x, car, cac);
				}
				if (rh == (car + 3) && ch == cac)
				{
					u++;
				}
				if (x[ecar][ecac + 3] != char(178))
				{
					FillEnemyCar(x, ecar, ecac, p);
					MEC(x, ecar, ecac, p);
				}

				FillHeroInX3(x, rh, ch, u, m);


				Disp(x);


			}
			Q = _getch();	// cin>>Q;
			if (Q == 'e')
			{
				m++;
				if (m == 4)
				{
					m = 0;
				}
			}
			MoveHeroPosition3(rh, ch, Q);
		}
	}
}