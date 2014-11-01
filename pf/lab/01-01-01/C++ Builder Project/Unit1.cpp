// ---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
// ---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;

// ---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner) : TForm(Owner) {
}

// ---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender) {
	int a, b, c;
	a = StrToInt(Edit1->Text);
	b = StrToInt(Edit2->Text);
	c = StrToInt(Edit3->Text);
	if (a > b) {
		if (a > c) {
			Label5->Caption = IntToStr(a);
		}
		else {
			Label5->Caption = IntToStr(c);
		}
	}
	else if (b > c) {
		Label5->Caption = IntToStr(b);
	}
	else
		Label5->Caption = IntToStr(c);
}

// ---------------------------------------------------------------------------
