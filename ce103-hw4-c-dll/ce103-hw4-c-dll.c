
#include "ce103-hw4-c-dll.h"

/**
*
*	  @name   fibonacciNumber (ce103_fibonacciNumber)
*
*	  @brief Fibonacci Number Calculator
*
*	  Calculates the fibonacci number in the given index and return as output
*
*	  @param  [in] fiIndex [\b int]  index of fibonacci number in the serie
*
*	  @retval [\b int] calculated fibonacci number
**/
int ce103_fibonacciNumber(int fiIndex)
{
	//TODO:Start from Here...
	{

		int x = 0, y = 1, z, d;
		//we created int type variables named x,,y,z and d.
		//we set variable x to 0 and variable y to 1.
		if (fiIndex == 0)
			//The condition is true if the variable fiIndex is equal to 0.
			return x;
		for (d = 2; d <= fiIndex; d++)
			// if d is less than or equal to fiIndex continue the loop otherwise exit
		{
			z = x + y;
			x = y;
			y = z;
		}
		return x;
		//we returned to 'x'.
	}
	;
}
/**
	@name   strrev (ce103_strrev)

	@brief \b Reverse String

	Reverse given string

	@param [in] fiStr [\b char*] The given string which is needed to be reversed.

	@retval [\b char*] This function returns the string after reversing the given string
**/
char* ce103_strrev(char* fiStr)
{
	//TODO:Start from Here...
	char ch;
	//char type pointer definition
	char* a = fiStr;
	char* b = fiStr;
	//a and b pointer definition

	for (; *b != '\0'; b++);
	//continue loop if b is not equal to 'null character' otherwise exit
	;
	b--;
	for (; a < b; a++, b--)
		//if a is less than b, a increases and b decreases.
	{
		ch = *a;
		*a = *b;
		*b = ch;
	}
	return fiStr;
	//return command given to 'fiStr'.
}

/**
	@name   strlen (ce103_strlen)
	@brief \b Get string length

	Returns the length of the C string str.

	The length of a C string is determined by the terminating null-character:
	A C string is as long as the number of characters between the beginning of
	the string and the terminating null character
	(without including the terminating null character itself).

	see more <a href="https://en.cppreference.com/w/c/string/byte/strlen">strlen reference 1</a>
	see more <a href="https://www.programiz.com/c-programming/library-function/string.h/strlen">strlen reference 2</a>
	see more <a href="https://www.cplusplus.com/reference/cstring/strlen/">strlen reference 3</a>

	@param [in] fiStr [\b const char*] pointer to the null-terminated byte string to be examined

	@retval [\b int] The length of the null-terminated byte string str.
**/
int ce103_strlen(const char* fiStr)
{
	//TODO:Start from Here...

	if (*fiStr == '\0')
		//The condition is true if the* fiStr variable equals a null character.
	{
		return 0;
		//return command given to '0'
	}
	return 1 + ce103_strlen(fiStr + 1);

}


/**
	@name   strcat (ce103_strcat)
	@brief \b Concatenate strings

	Appends a copy of the null-terminated byte string pointed to by src to the end of the null-terminated byte string pointed to by dest

	The character src[0] replaces the null terminator at the end of dest. The resulting byte string is null-terminated.

	The behavior is undefined if the destination array is not large enough for the contents of
	both src and dest and the terminating null character. The behavior is undefined if the strings overlap.
	The behavior is undefined if either dest or src is not a pointer to a null-terminated byte string.

	see more <a href="https://en.cppreference.com/w/c/string/byte/strcat">strcat reference</a>
	see more <a href="https://www.cplusplus.com/reference/cstring/strcat/">strcat reference</a>

	@param  [in] fiDest [\b char*] pointer to the null-terminated byte string to append to
	@param  [in] fiSrc  [\b char*] pointer to the null-terminated byte string to copy from

	@retval [\b char*] returns a copy of dest
**/
char* ce103_strcat(char* fiDest, char* fiSrc)
{
	//TODO:Start from Here...


	char* start = fiDest;
	//char type pointer definition
	//we set variable start to fiDest.
	while (*fiDest != '\0')
		//continue loop if fiDest is not equal to null character ' otherwise exit
	{
		fiDest++;
	}

	while (*fiSrc != '\0')
		//continue loop if fiSrc is not equal to 'null character ' otherwise exit
	{
		*fiDest = *fiSrc;
		fiDest++;
		fiSrc++;
	}

	*fiDest = '\0';
	return start;
	//return command given to 'start'.
}




/**
	@name   strcmp (ce103_strcmp)
	@brief  \b Compare two strings

	Compares two null-terminated byte strings lexicographically.

	The sign of the result is the sign of the difference between
	the values of the first pair of characters (both interpreted as unsigned char)
	that differ in the strings being compared.The behavior is undefined
	if lhs or rhs are not pointers to null-terminated byte strings.

	see more <a href="https://en.cppreference.com/w/c/string/byte/strcmp">strcmp reference</a>
	see more <a href="https://www.cplusplus.com/reference/cstring/strcmp/">strcmp reference</a>

	@param  [in] fiLhs [\b const char*] pointers to the null-terminated byte strings to compare
	@param  [in] fiRhs [\b const char*] pointers to the null-terminated byte strings to compare

	@retval [\b int] Negative value if lhs appears before rhs in lexicographical order.
			Zero if lhs and rhs compare equal.
			Positive value if lhs appears after rhs in lexicographical order.
**/
int ce103_strcmp(const char* fiLhs, const char* fiRhs)
{
	//TODO:Start from Here...
	int ret;
	//we created int type variable named ret.
	while ((ret = *fiLhs - *fiRhs++) == 0 && *fiLhs++);
	//continue if loop provides value, exit otherwise.
	return ret;
	//return command given to 'ret'.
}

/**
*
	@name  strcpy (ce103_strcpy)
	@brief \b Copy string

	Copies the C string pointed by source into the array pointed by destination,
	including the terminating null character (and stopping at that point).

	To avoid overflows, the size of the array pointed by destination shall be long enough to contain
	the same C string as source (including the terminating null character),
	and should not overlap in memory with source.

	see more <a href="https://en.cppreference.com/w/c/string/byte/strcpy">strcpy reference 1</a>
	see more <a href="https://www.cplusplus.com/reference/cstring/strcpy/">strcpy reference 2</a>

	@param [out] foDestination	[\b char*]			Pointer to the destination array where the content is to be copied.
	@param [in]  fiSource		[\b const char*]	C string to be copied.

	@retval returns a copy of dest
**/
char* ce103_strcpy(char* foDestination, const char* fiSource)
{
	//TODO:Start from Here...
	char* ret = foDestination;
	//char type pointer definition
	//we set variable ret to foDestination.
	while ((*foDestination++ = *fiSource++) != '\0');
	//continue if the loop is not equal to 'null character', otherwise exit
	return ret;
	//return command given to 'ret'.
}

/**
 * @name    hex2bin (ce103_hex2bin)
 * @brief   \b Hexadecimal to Binary (BCD)  Conversion
 *
 * Hexadecimal to Binary (BCD)  Conversion
 * Packs hexadecimal string to packed binary array, Example: "AB1234" => 0xAB 0x12 0x34
 * If length of the input string is less than the fiHexLen,remaining bytes is not filled.
 * If odd number of characters processed, last nibble is padded with 0
 *
 * @param   [in]  fiHex    [\b unsigned char*] Ascii hex string.
 * @param   [in]  fiHexLen [\b int]     Ascii data length.
 * @param  [out]  foBin    [\b char*]   Convertion result as binary.
 */
void ce103_hex2bin(char* fiHex, int fiHexLen, unsigned char* foBin)
{
	//TODO:Start from Here...
	int num1, num2;
	//We created int type variable named num1 and num2.
	for (;;) {
		num1 = *fiHex++; if (num1 == 0) break;
		//we set fihex equal to num1 if num1 equals 0 the loop repeats otherwise exit.
		if (num1 > 96) num1 -= 87;
		//if num1 bigger than 96 subtract 87 from num1 and contiue
		else if (num1 > 64) num1 -= 55;
		//if num1 bigger than 64 then subtract 55 from num1 and contiue
		else num1 -= 48;
		num2 = *fiHex++; if (num2 == 0) { *foBin = num1 << 4; break; }
		//We equate fihex to num2 then if num2 equal to 0 then contiue the other function
		if (num2 > 96) num2 -= 87;
		//if num2 is bigger than 96 then subtract 87 from num2 and continue
		else if (num2 > 64) num2 -= 55;
		else num2 -= 48;
		*foBin++ = (num1 << 4) | num2;
		//num1 shifting the number 1 to the left 0 bits or num2 are equal to fobin++
	}
	return fiHex;
	//Return command given to 'fiHex'.
}

/**
* @name    bin2hex (ce103_bin2hex)
* @brief   \b Binary (BCD) to Hexadecimal Conversion
*
* Unpacks alpha numeric value, Example: 0x12 0x34 = "1234".
*
* @param [in]  fiBin      [\b unsigned char*]    Binary data to be converted.
* @param [in]  fiBinLen   [\b int]				 Binary data length.
* @param [out] foHex      [\b char*]			 Convertion result as ascii. Doubles the binary length.
*
*/
void ce103_bin2hex(unsigned char* fiBin, int fiBinLen, char* foHex)
{
	//TODO:Start from Here...
	int i;
	//we created int type variable named i.
	for (i = 0; i < fiBinLen; i++)
		//continue if i is less than fiBinLen, otherwise exit
	{
		foHex[i * 2] = "0123456789ABCDEF"[fiBin[i] >> 4];
		foHex[i * 2 + 1] = "0123456789ABCDEF"[fiBin[i] & 0x0F];
	}
	//We changed fohex value one by one and then we converting bin values to hex
	foHex[fiBinLen * 2] = '\0';
	//The resultant value of fohex multiplied by the fiblen value of 2 is equal to 0.
	return foHex;
	//return command given to 'foHex'
}

