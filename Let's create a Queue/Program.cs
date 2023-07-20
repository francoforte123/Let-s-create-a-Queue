using Let_s_create_a_Queue;

ILogger logger= new ConsoleLog();

var myQueueInteger= new MyQueueInteger();

myQueueInteger.Queue(1);
myQueueInteger.Queue(2);
myQueueInteger.Queue(3);
myQueueInteger.Queue(4);

myQueueInteger.Dequeue();
myQueueInteger.Peek();

logger.LogSum(myQueueInteger);

//-------------------------------------------

var myQueueString = new MyQueueString();

myQueueString.Queue("Marco");
myQueueString.Queue("Luca");
myQueueString.Queue("Emanuele");
myQueueString.Queue("Alberto");

myQueueString.Dequeue();
myQueueString.Peek();

logger.LogSum(myQueueString);



