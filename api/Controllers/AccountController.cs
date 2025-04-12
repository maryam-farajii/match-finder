namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        #region Constructor 
        private readonly IMongoCollection<AppUser> _collection;

        // Dependency Injection
        public AccountController(IMongoClient client, IMongoDbSettings dbSettings)
        {
            var dbName = client.GetDatabase(dbSettings.DatabaseName);
            _collection = dbName.GetCollection<AppUser>("users");
        }
        #endregion

        // [HttpPost("register")]
        // public async task<ActionResult<AppUser>> Register(AppUser userInput, CancellationToken cancellationToken)
        // {
        //     AppUser user = await _collection.Find<AppUser>(doc => doc.Email == userInput.Email).FirstOrDefaultasync(cancellationToken);

        //     if (user is null)
        //     {
        //         await _collection.InsertOneasync(userInput, null, cancellationToken);

        //         return userInput;
        //     }

        //     return BadRequest("Your email is already registered");
        // }

        // [HttpGet]
        // public async task<ActionResult<List<AppUser>>> GetAll(CancellationToken cancellationToken)
        // {
        //     List<AppUser> appUsers = await _collection.Find<AppUser>(new BsonDocument()).ToListasync(cancellationToken);

        //     if (appUsers.Count == 0)
        //     {
        //         return NoContent();
        //     }

        //     return appUsers;
        // }

        // [HttpGet("get-by-username/{usernameInput}")]
        // public async task<ActionResult<AppUser>> GetByUserName(string usernameInput, CancellationToken cancellationToken)
        // {
        //     AppUser user = await _collection.Find<AppUser>(doc => doc.UserName == usernameInput).FirstOrDefaultasync(cancellationToken);

        //     if (user is null)
        //     {
        //         return NotFound("No user found with this username!");
        //     }

        //     return user;
        // }

        // [HttpPut("update/{userId}")]
        // public async task<ActionResult<AppUser>> UpdateById(string userId, AppUser userInput, CancellationToken cancellationToken)
        // {
        //     UpdateDefinition<AppUser> updateDef = Builders<AppUser>.Update
        //     .Set(user => user.UserName, userInput.UserName.Trim().ToLower())
        //     .Set(user => user.Age, userInput.Age);

        //     await _collection.UpdateOneasync(user => user.Id == userId, updateDef);

        //     AppUser appUser = await _collection.Find(User => User.Id == userId).FirstOrDefaultasync(cancellationToken);

        //     return appUser;
        // }

        // [HttpDelete("delete/{userId}")]
        // public async task<ActionResult<DeleteResult>> DeleteById(string userId, CancellationToken cancellationToken)
        // {
        //     AppUser appUser = await _collection.Find<AppUser>(doc => doc.Id == userId).FirstOrDefaultasync(cancellationToken);

        //     if (appUser is null)
        //     {
        //         return BadRequest("user not Fond!");
        //     }

        //     return await _collection.DeleteOneasync<AppUser>(doc => doc.Id == userId).FirstOrDefaultasync(cancellationToken);
        // }





        // [HttpPost("register")]
        // public AppUser RegisterUser(AppUser userInput)
        // {
        //     AppUser user = new AppUser(
        //         Id: null,
        //         Email: userInput.Email,
        //         Name: userInput.Name,
        //         Password: userInput.Password,
        //         ConfirmPassword: userInput.ConfirmPassword
        //     );

        //     _collection.InsertOne(user);

        //     return user;
        // // }


        // [HttpPost("register")]
        // public ActionResult<AppUser> Register(AppUser userInput)
        // {
        //     AppUser user = _collection.Find<AppUser>(doc => doc.Email == userInput.Email).FirstOrDefault();

        //     if (user is null)
        //     {
        //         _collection.InsertOne(userInput);

        //         return userInput;
        //     }

        //     return BadRequest("Your email is already registered");
        // }

        // [HttpGet]
        // public ActionResult<List<AppUser>> GetAll()
        // {
        //     List<AppUser> appUsers = _collection.Find<AppUser>(new BsonDocument()).ToList();

        //     if (appUsers.Count == 0)
        //     {
        //         return NoContent();
        //     }

        //     return appUsers;
        // }

        // [HttpGet("get-by-username/{usernameInput}")]
        // public ActionResult<AppUser> GetByUserName(string usernameInput)
        // {
        //     AppUser user = _collection.Find<AppUser>(doc => doc.UserName == usernameInput).FirstOrDefault();

        //     if (user is null)
        //     {
        //         return NotFound("No user found with this username!");
        //     }

        //     return user;
        // }

        // [HttpPut("update/{userId}")]
        // public ActionResult<AppUser> UpdateById(string userId, AppUser userInput)
        // {
        //     UpdateDefinition<AppUser> updateDef = Builders<AppUser>.Update
        //     .Set(user => user.UserName, userInput.UserName.Trim().ToLower())
        //     .Set(user => user.Age, userInput.Age);

        //     _collection.UpdateOne(user => user.Id == userId, updateDef);

        //     AppUser appUser = _collection.Find(User => User.Id == userId).FirstOrDefault();

        //     return appUser;
        // }

        // [HttpDelete("delete/{userId}")]
        // public ActionResult<DeleteResult> DeleteById(string userId)
        // {
        //     AppUser appUser = _collection.Find<AppUser>(doc => doc.Id == userId).FirstOrDefault();

        //     if (appUser is null)
        //     {
        //         return BadRequest("user not Fond!");
        //     }

        //     return _collection.DeleteOne<AppUser>(doc => doc.Id == userId);
        // }
    }
}

