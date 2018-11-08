
dseg	segment

	enx1	db	"Enter x1 (0-640): $"
	enx2	db	"Enter x2 (0-640): $"
	eny1	db	"Enter y1 (0-480): $"
	eny2	db	"Enter y2 (0-480): $"
	enColor	db	"Enter Color (1-10): $"
	error	db	"You need to enter x less than 640 and y less than 480. Please press any key to continue...$"
	count	dw	?
	a		dw	4,4 dup(?)
	x1		dw	1 dup(?)
	y1		dw	1 dup(?)
	x2		dw	1 dup(?)
	y2		dw	1 dup(?)
	color	dw	?
	y1s		dw	1 dup(?)
	y1new	dw	1 dup(?)
	case	db	1 dup(?)
	deltax	dw	?
	deltay	dw	?
	dydivdx	dw	?
dydivdxs	dw	?
	dlower	dw	-1
	dupper	dw	0
	len		dw	0
	dseg	ends

	cseg	segment
	assume cs:cseg, ds:dseg
		cleanPage proc
						;textmode
						mov ah, 00h
						mov al, 03h
						int 10h
						;textmode
						
						mov bx, 25
						mov ah, 02h
Clean:					mov dl, 10h
						int 10h
						mov dl, 13h
						int 21h
						dec bx
						jnz Clean
					
						;graphic mode
						mov ax, 12h
						int 10h
						;graphic mode
				ret
		cleanPage endp

		countXY proc ;	
						mov ax, 0
						mov bx, 0
						mov cx, 0
						mov dx, 0
						mov si, 0
						mov bp, 0



						mov  ax, dseg
						mov ds, ax
						mov ah, 0ah
						mov dx, offset a
						int 21h	
						mov dx, a[1]
						mov	dh, 0
						mov len, dx
						mov bp, 0

						mov ax, dseg
						mov ds, ax
						mov si, offset a
						add si, 2

						
Again:					mov ax, 0
						mov al, 10
						mul bx
						mov cx, ds:[si]
						mov ch, 0
						sub cx, 30h
						add ax, cx
						mov bx, ax
						inc si
						inc bp
						cmp bp, len
						jnz Again

						cmp count, 0
						jnz afterX1
						mov x1, bx
						jmp toend

afterX1:				cmp count, 1
						jnz afterX2
						mov x2, bx
						jmp toend

afterX2:				cmp count, 2
						jnz afterY1
						mov y1, bx
						jmp toend
afterY1:				cmp count,3
						jnz afterY2
						mov y2, bx
						jmp toend
afterY2:				mov color, bx
						jmp toend
				
toend:			ret
		countXY endp

		;;;;	Part	1	;;;;;
		;main
		start:		mov [a+4], ?
		mov[a+5],?
		mov[a+6],?
		mov [a+7],?

						call cleanPage
						;graphic mode
						mov ax, 12h
						int 10h
						;graphic mode

						;x1

						;changecursorposition
						mov ah, 02h
						mov bh, 0
						mov dh, 0
						mov dl, 0
						int 10h
						;changecursorposition

						;DisplayString
						mov ax, dseg
						mov ds, ax
						mov dx, offset enx1
						mov ah, 09h
						int 21h
						;DisplayedString

						mov count, 0 ; Telling the function its x1
						call countXY
						;x1

						;x2
						;changecursorposition
						mov ah, 02h
						mov bh, 0
						mov dh, 1
						mov dl, 0
						int 10h
						;changecursorposition

						;DisplayString
						mov ax, dseg
						mov ds, ax
						mov dx, offset eny1
						mov ah, 09h
						int 21h
						;DisplayedString
							mov count, 2 ; Telling the function its y1
					
						call countXY
						;x2

						;y1
						;changecursorposition
						mov ah, 02h
						mov bh, 0
						mov dh, 2
						mov dl, 0
						int 10h
						;changecursorposition

						;DisplayString
						mov ax, dseg
						mov ds, ax
						mov dx, offset enx2
						mov ah, 09h
						int 21h
						;DisplayedString
						 	mov count, 1 ; Telling the function its x2
					
						call countXY
						;y1

						;y2
						;changecursorposition
						mov ah, 02h
						mov bh, 0
						mov dh, 3;shura
						mov dl, 0;amuda
						int 10h
						;changecursorposition

						;DisplayString
						mov ax, dseg
						mov ds, ax
						mov dx, offset eny2
						mov ah, 09h
						int 21h
						;DisplayedString
						mov count, 3 ; Telling the function its y2
						call countXY


						;changecursorposition
						mov ah, 02h
						mov bh, 0
						mov dh, 4;shura
						mov dl, 0;amuda
						int 10h
						;changecursorposition

						;DisplayString
						mov ax, dseg
						mov ds, ax
						mov dx, offset enColor
						mov ah, 09h
						int 21h
						;DisplayedString
						mov count, 4 ; Telling the function its y2
						call countXY
						;y2
						;end of calculating x1,y1,x2,y2
						call cleanPage
						cmp x1,640
						jnc Message
						cmp x2,640
						jnc Message
						cmp y1, 480
						jnc Message
						cmp y2, 480
						jnc Message	
						cmp color, 1
						jc Message
						cmp color, 11
						jnc Message
						jmp Continue



Message:				call cleanPage
						;DisplayString
						mov ax, dseg
						mov ds, ax
						mov dx, offset error
						mov ah, 09h
						int 21h
						;DisplayedString
						;input for reloading
						mov ah, 01
						int 21h
						;input for reloading
						mov ah, 00h
						mov al, 03h
						int 10h
						jmp start

						;;;;	End		Part 1	;;;;;

						;;;; Part 2	;;;;
Continue:				;draw pixel
						mov cx, x1
						mov dx, y1
						mov ax, color
						mov bh, 0
						mov ah, 0ch
						int 10h
						;draw pixel

						mov ax, y1
						mov y1new, ax
						;case checking;
						mov ax, x2
						cmp x1, ax
						jz x1equalx2
						jc x1x2
						jnc x2x1
					

x1x2:					mov ax, y2
						cmp y1, ax
						jz y1equaly2
						jc case0
						jnc case1
						mov case, 1
						jmp	endCase
case0:					mov case, 0
						jmp endCase
case1:					mov case, 1
						jmp endCase

x2x1:					mov ax, y2
						cmp y1, ax
						jc case2
						jnc case3
case2:					mov case, 2
						jmp endCase
case3:					mov case, 3
						jmp endCase

x1equalx2:				mov ax, y2
						cmp y1, ax
						jc case4
						jnc case5
case4:					mov case, 4
						jmp endCase
case5:					mov case, 5
						jmp endCase

						mov ax, y2
						cmp y1, ax
						jz y1equaly2
						jmp endCase

y1equaly2:				mov ax, x2
						cmp x1, ax
						jc case6
						jnc case7
case6:					mov case, 6
						jmp endCase
case7:					mov case, 7
						jmp endCase			
			
						

endCase:				mov ax, 0
						mov al, case
						;;;;	End		Part2	;;;;
						;Here we have x1,x2,y1,y2 and we have checked if its matching the resulotion + case number.

						;;;; Part 3	;;;;
						cmp case, 0
						jz ifCase0

						cmp case, 1
						jz ifCase1

						cmp case, 2
						jz ifCase2

						cmp case, 3
						jz ifCase3

						jmp Repeat ; if the case is 4 or 5 or 6 or 7 skip afterCheck because you don't need to put value on dydivdx and etc.

ifCase0:				mov ax, y2
						sub ax, y1
						mov bx, x2
						sub bx, x1
						jmp afterCheck

ifCase1:				mov ax, y1
						sub ax, y2
						mov bx, x2
						sub bx, x1
						jmp afterCheck

ifCase2:				mov ax, y2
						sub ax, y1
						mov bx, x1
						sub bx, x2
						jmp afterCheck	

ifCase3:				mov ax, y1
						sub ax, y2
						mov bx, x1
						sub bx, x2
						jmp afterCheck

		
							
afterCheck:				mov deltax, bx
						mov deltay, ax
						mov dx, 0
						div bx
						mov dydivdx, ax
						mov dydivdxs, dx
						mov ax, dydivdxs
						mov y1s, ax
						;;;;	End	Part 3	;;;;


						;;;;	Part	4	;;;;
Repeat:				
					

						cmp case, 0
						jz addCase0

						cmp case, 1
						jz addCase1

						cmp case, 2
						jnz chkCase3
						jmp addCase2

chkCase3:				cmp case, 3
						jnz chkCase4
						jmp addCase3

chkCase4:				cmp case, 4
						jnz chkCase5
						jmp addCase4

chkCase5:				cmp case, 5
						jnz chkCase6
						jmp	addCase5

chkCase6:				cmp case, 6
						jnz chkCase7
						jmp	addCase6

chkCase7:				jmp addCase7

;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

addCase0:				inc x1

						mov ax, dydivdx
						add y1new, ax
						mov ax, dydivdxs
						add y1s, ax

						mov ax, y1s
						mov dx, 0
						div deltax
						add y1new, ax
						mov y1s, dx
				
						mov ax, y1new
						mov dlower, ax
						inc ax
						mov dupper, ax
						mov ax, 2
						mov dx, 0
						mul y1s
						cmp ax, deltax
						jnc continueCase0
						jmp closedLower
		continueCase0:	jmp closedUpper
					


addCase1:				inc x1

						mov ax, dydivdx
						sub y1new, ax
						mov ax, dydivdxs
						add y1s, ax

						mov ax, y1s
						mov dx, 0
						div deltax
						sub y1new, ax
						mov y1s, dx

						mov ax, y1new
						mov dlower, ax
						dec ax
						mov dupper, ax
						mov ax, 2
						mov dx, 0
						mul y1s
						cmp ax, deltax
						jnc continueCase1
						jmp closedLower
		continueCase1:	jmp closedUpper

addCase2:				dec x1
						mov ax, dydivdx
						add y1new, ax
						mov ax, dydivdxs
						add y1s, ax

						mov ax, y1s
						mov dx, 0
						div deltax
						add y1new, ax
						mov y1s, dx

						mov ax, y1new
						mov dlower, ax
						inc ax
						mov dupper, ax
						mov ax, 2
						mov dx, 0
						mul y1s
						cmp ax, deltax
						jnc continueCase2
						jmp closedLower
		continueCase2:	jmp closedUpper

addCase3:				dec x1

						mov ax, dydivdx
						sub y1new, ax
						mov ax, dydivdxs
						add y1s, ax

						mov ax, y1s
						mov dx, 0
						div deltax
						sub y1new, ax
						mov y1s, dx

						mov ax, y1new
						mov dlower, ax
						dec ax
						mov dupper, ax
						mov ax, 2
						mov dx, 0
						mul y1s
						cmp ax, deltax
						jnc continueCase3
						jmp closedLower
		continueCase3:	jmp closedUpper

addCase4:				inc y1
						mov ax, y1
						mov dlower,ax
						jmp closedLower

addCase5:				dec y1
						mov ax, y1
						mov dlower,ax
						jmp closedLower

addCase6:				inc x1
						mov ax, y1
						mov dlower,ax
						jmp closedLower

addCase7:				dec x1
						mov ax, y1
						mov dlower,ax
						jmp closedLower



												
closedUpper:			;draw pixel
						mov cx, x1
						mov dx, dupper
						mov ax, color
			

						mov bh, 0
						mov ah, 0ch
						int 10h
						;draw pixel
						jmp bend

closedLower:			;draw pixel
						mov cx, x1
						mov dx, dlower
					
						mov ax, color

						mov bh, 0
						mov ah, 0ch
						int 10h
						;draw pixel			
						;;;;	End	Part 4	;;;;

						;;;;	Part	5	;;;;
bend:					cmp case, 0
						jz asCase0

						cmp case, 1
						jz asCase1

						cmp case, 2
						jz asCase2

						cmp case, 3
						jnz bAsCase3
						jmp asCase3
bAsCase3:				
						cmp case, 4
						jnz bAsCase4
						jmp asCase4
bAsCase4:				
						cmp case, 5
						jnz bAsCase5
						jmp asCase4
bAsCase5:				

						cmp case, 6
						jnz bAsCase6
						jmp asCase6
bAsCase6:				
						cmp case, 7
						jnz bAsCase7
						jmp asCase6
bAsCase7:				

asCase0:				
						mov ax, x2
						cmp x1, ax
						jz Reload
						jmp Repeat
			
asCase1:				
						mov ax, x2
						cmp x1, ax
						jz Reload
						jmp Repeat

asCase2:			
						mov ax, x2
						cmp x1, ax
						jz Reload
						jmp Repeat


asCase3:		
						mov ax, x2
						cmp x1, ax
						jz Reload
						jmp Repeat

asCase4:				mov ax, y2
						cmp y1, ax
						jz Reload
						jmp Repeat
						
asCase6:				mov ax, x2
						cmp x1, ax
						jz Reload
						jmp Repeat
						
Reload:					;input for reloading
						mov ah, 01
						int 21h
						jmp start
						;input for reloading
			
				
tend:					int 3h
		;;;;	End	Part	5	;;;;
cseg	ends
end		start
