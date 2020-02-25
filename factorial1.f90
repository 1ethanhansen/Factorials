!------------------------------------------------------------------------------------------------------------------------
! Description : This is a Fortran program to demonstrate factorial calculation. This fortran function returns the factorial for the non negative number. It returns -1, if the number is negative.
! Author: Rajesh Prashanth <rajeshprasanth@rediffmail.com>
! Created on Thu Jan 23 03:05:00 IST 2020
!------------------------------------------------------------------------------------------------------------------------
! Use any fortran compiler for compilation
! 
! For an instance,
!
! $ gfortran factorial1.f90 -o factorial1
!
!------------------------------------------------------------------------------------------------------------------------
function factorial1(num_in) result (fac_out)
	integer, intent(in) :: num_in
	integer :: fac = 1, counter,fac_out
	
	counter=num_in
	
	if (num > 0) then
		do while (counter > 1) 
			fac = fac * counter
			counter = counter - 1 
		end do
		fac_out = fac
	else 
		fac_out = -1
	end if 
end function factorial1

program factorial_driver
	integer:: input,factorial1
	write(*,*)'Enter the number >>> '
	read(*,*)input
	if (factorial1(input) < -1 ) then
		write(*,*) 'Invalid Number in input !!!'
	else
		write(*,*) 'Factorial for',input, ' is ', factorial1(input)
	end if
end program factorial_driver
