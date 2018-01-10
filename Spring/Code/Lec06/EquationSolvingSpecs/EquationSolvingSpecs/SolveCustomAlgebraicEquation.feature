Feature: solving custom algebraic equation
	In order to demonstrate how the algebraic equations are solved
	As a school math teacher
	I want to get the roots of algebraic equation

@math @ordinary
Scenario: Solve ordinary algebraic equation with real roots
	Given I have specified array of coefficients { 1, 3, -5, -15, 4, 12 }
	When I press Solve
	Then the array of roots should be { -3, -2, -1, 1, 2 }

@math @exception
Scenario: Solve algebraic equation with no unknowns
	Given I have set 0
	And I have set 0
	And I have set 3
	When I press Solve
	Then argument exception must occur
