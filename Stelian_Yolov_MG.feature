Feature: Verify Password acceptance criteria for MoneyGaming (Min 6 character with at least one number and at least one special character)

  Scenario: TC01 - Valid Password with 6 character

    Given User is on Home Page
    And Navigate to Registration form
    When User enters personal information
    And enters "<Password>" twice
	Then User is able to successfully register on to website
	
@Valid
Examples:
|password|
|1abcd!|
|12345!|
|!!!!!1|
|12ab!!|

  Scenario: TC02 - Invalid Password with 6 character

    Given User is on Home Page
    And Navigate to Registration form
    When User enters personal information
    And enters "<Password>" twice
	Then User will not be able to register on to website
	
@Invalid
Examples:
|password|
|1abcde|
|abcdef|
|abcde!|
|123456|
|!!!!!!|

  Scenario: TC03 - Invalid Password with 5 character

    Given User is on Home Page
    And Navigate to Registration form
    When User enters personal information
    And enters "<Password>" twice
	Then User will not be able to register on to website
	
@Invalid
Examples:
|password|
|1abc!|
|abcdef|

  Scenario: TC04 - Valid Password with more than 6 character

    Given User is on Home Page
    And Navigate to Registration form
    When User enters personal information
    And enters "<Password>" twice
	Then User is able to successfully register on to website
	
@Valid
Examples:
|password|
|1abcde!|
|123456!|
|!!!!!!1|
|12abc!!|

  Scenario: TC05 - Invalid Password with more than 6 character

    Given User is on Home Page
    And Navigate to Registration form
    When User enters personal information
    And enters "<Password>" twice
	Then User will not be able to register on to website
	
@Invalid
Examples:
|password|
|1abcdef|
|abcdefg|
|abcdef!|
|1234567|
|!!!!!!!|
