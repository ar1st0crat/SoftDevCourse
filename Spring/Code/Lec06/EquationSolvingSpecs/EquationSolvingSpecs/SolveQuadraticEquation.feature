Feature: solving quadratic equation
	In order to demonstrate that Quadratic Formula really works
	As a school math teacher
	I want to get the roots of quadratic equation

@math @ordinary
Scenario Outline: Solve ordinary quadratic equation
	Given I have set <coefficient1>
	And I have set <coefficient2>
	And I have set <coefficient3>
	When I press Solve
	Then the roots should be <root1> and <root2>

Examples: 
| coefficient1 | coefficient2 | coefficient3   | root1 | root2 |
| 1            | 1            | -6             | -3    |  2    |
| 1            | 0            | -4			   |  2    | -2    |
| 1            | 5            |  0			   |  0    | -5    |


@math @exception
Scenario: Solve ordinary quadratic equation with no real roots
	Given I have set 1
	And I have set 1
	And I have set 6
	When I press Solve
	Then exception must occur
