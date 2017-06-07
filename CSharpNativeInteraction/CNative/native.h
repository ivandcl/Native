#pragma once

#define DLLEXPORT __declspec(dllexport)

extern "C"{
	DLLEXPORT double NativeSum(double a, double b);
}
