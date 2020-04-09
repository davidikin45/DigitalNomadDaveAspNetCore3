Feature: Contact
	In order to ask you to work for me
	As potential employer
	I want to send you a message

Background: 
	Given I am on the contact screen

@contact
Scenario: Message sent successfully
	And I enter name of James Smith
	And I enter email of test@gmail.com
	And I enter subject as Enquiry
	And I enter mesage as This is a test message
	When I submit the contact form
	Then I should see the confirmation message

@contact
Scenario Outline: Cannot submit contact form unless name is entered
	And I enter email of test@gmail.com
	And I enter subject as <subject>
	And I enter mesage as This is a test message
	When I submit the contact form
	Then I should see an error message telling me the Name field is required 

	Examples: 
	| subject                     |
	| Hello                       |
	| Enquiry                     |
	| Are you available for work? |

@contact
Scenario: Cannot submit contact form unless name is entered using table
	Given I enter the following values
	| field     |	value				 |
	| email     | test@gmail.com		 |
	| subject   | Enquiry				 |
	| mesage    | This is a test message |
	When I submit the contact form
	Then I should see an error message telling me the Name field is required