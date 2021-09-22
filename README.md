# DesignPatterns
 
#[Decorator Pattern](Assets\Decorator%20Pattern)
Attempt at making a Decorator pattern System.

I didn't really like the whole "bullet = new firebullet(new icebullet(new bullet()))" Idea
hard to remove decorations and see what decorations are currently on it

therefore this
iDecorator inherits from ICloneable so its easy to copy, this way you can for instance store a list of iDecorators on a gun, 
and then just clone those and put em on bullet O_O

iDecoratorData so data is persistent across decorations.
You could have DecoratorData that's for a whole enemy like EnemyDecoratorData
or perhaps if you want an effect to happen every action like when an enemy attacks
this does create annoying CASTING you need to do everytime you call initialize,remove or execute

I quickly had an idea of how to implement it, with a few hickups a long the way I believe I created a pretty neat system.

also created a servicedesk for ease of finding the particleObjects.
