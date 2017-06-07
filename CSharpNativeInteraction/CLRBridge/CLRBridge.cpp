// This is the main DLL file.

#include "stdafx.h"

#include "CLRBridge.h"
#include "..\CNative\native.h"

double CLRBridge::Calc::Sum(double a, double b)
{
	return NativeSum(a, b);
}
