#include "stm32f0xx.h"                  // Device header

int main(void)
{
	RCC->AHBENR |= RCC_AHBENR_GPIOBEN;
  GPIOB->MODER |= GPIO_MODER_MODER0_0 | GPIO_MODER_MODER8_0;	
}
