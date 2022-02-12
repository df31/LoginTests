Feature: Login

@Positive
Scenario Outline: Login success
	Given user typed in <username> and <password>
	When the credential is submitted
	Then login process should be success

	Examples:
		| username | password             |
		| tomsmith | SuperSecretPassword! |

@Negative
Scenario Outline: Login failed
	Given user typed in <username> and <password>
	When the credential is submitted
	Then <errormsg> is showed

	Examples:
		| username | password             | errormsg                  |
		|          |                      | Your username is invalid! |
		| John Doe |                      | Your username is invalid! |
		| John Doe | SuperSecretPassword! | Your username is invalid! |
		| tomsmith |                      | Your password is invalid! |
		| tomsmith | SecretPassword       | Your password is invalid! |