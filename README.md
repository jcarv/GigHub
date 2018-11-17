# Pluralsight course: Become a Full-Stack .NET Developer


## Extracting Core Use Cases from Requirements

**Requirements:**

GigHub is a mini social network that makes it really easy for live music lovers to track the gigs of their favorite artists.

Artists can signup and list their gigs. When adding a gig, they should specify the date/time, location and genre of the gig.

An artist should have a page called My Upcoming Gigs. From there, they should be able to edit or remove an existing gig, or add another gig to the list.

Users should be able to view all upcoming gigs or search them by artist, genre or location. They should be able to view details of a gig and add it to their calendar.

Aditionally, users should be able to follow their favorite artists. When they follow an artist, they should see the upcoming gigs of their favorite artists in the Gig Feed.

**Extracting Use Cases:**

Some of these do not appear in the early requirements document. Which is why this document should be used as a tool to get an high level understanding of the project.
As we progress we should use our own judgement or comunicate with the business or the client to fill the missing parts.

**Examples:**
In this particular case, we can tell that since we have **Sign Up** we should also have **Login**, **Log Out**, etc.
Another example would be the **Gig Calendar**. Since we have **Add a gig to calendar**, we should also probably have the rest of the use cases listed on that section.
**Following an artist** was also on the requirements document, so the rest of the use cases listed on that section should also be required.

**Authentication**
- Sign up 
- Login 
- Log out 
- Change password 
- Edit profile

**Gigs**
- Add a gig
- My upcoming gigs (for artist)
- Edit a gig
- Remove a gig
- View all upcoming gigs
- Search
- View gig details

**Gig Calendar**
- Add a gig to calendar
- Remove a gig from calendar
- View gigs I'm attending

**Following**
- Follow an artist
- Unfollow an artist
- Who i'm following
- Gig feed

**Dependencies Between Use Cases**

|   1       |       2           |           3           |            4            |               5            |
| --------- | ----------------- | --------------------- | ----------------------- | -------------------------- |
| Add a gig | My upcoming gigs  | Edit a gig            | View gigs I'm Attending | Remove a gig from calendar |
|           | All upcoming gigs | Remove a gig          | Who I'm following       | Unfollow an artist         |
|           |                   | Add a gig to calendar | Gig feed                |                            |
|           |                   | Follow an artist      |                         |                            |
|           |                   | Search                |                         |                            |
|           |                   | View gig details      |                         |                            |

**Core use cases (Use cases that shape the domain of our application):**
    - Add a gig
    - Add a gig to calendar
    - Follow an artist

**Supporting use cases (Use cases that report the state of the application):**
    - All upcoming gigs (bridges the gap between the core use cases in the first and third columns)
    - View gigs I'm attending
    - Who I'm following

    These use cases were chosen so we can build a piece of funcionality end to end, helping us build the skeleton of our application while adding new features to it.
    Once the skeleton is ready we can write automated tests using selenium to test the application funcionality end to end.
