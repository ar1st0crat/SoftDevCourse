Feature: SearchCSharpFeature
	In order to download WebDriver for C# 
	As a Selenium website visitor
	I want to check that corresponding download link exists

Scenario: Search for C# download link
	Given I have opened Selenium search page
	And I have entered C#
	When I press search button
	Then the search results contain Downloads

