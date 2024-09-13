using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInteger {

    abstract class AbstractFactoryEnemyBoss {
        public abstract Weapon GetWeapon();
        public abstract EnemyBossAi GetAi();
    }

    class EasyBossDifficulty : AbstractFactoryEnemyBoss {
        public override EnemyBossAi GetAi() {
            return new IntroEnemyAi();
        }

        public override Weapon GetWeapon() {
            return new Sword();
        }
    }
    class  MediumBossDifficulty : AbstractFactoryEnemyBoss {
        public override EnemyBossAi GetAi() {
            return new IntroEnemyAi();
        }

        public override Weapon GetWeapon() {
            return new Fireball();
        }
    }
    class  HardBossDifficulty : AbstractFactoryEnemyBoss {
        public override EnemyBossAi GetAi() {
            return new AggressiveEnemyAi();
        }

        public override Weapon GetWeapon() {
            return new MachineGun();
        }
    }



    class Hero {

        public int HealthPoints { get; set; }
    }

    abstract class Weapon {
        public abstract void DealDamage(Hero hero);
    }

    class Sword : Weapon {

        private int damage = 15;
        public override void DealDamage(Hero hero) {
            hero.HealthPoints -= damage;
        }
    }
    class MachineGun : Weapon {

        private int damage = 5;
        private int bullets = 15;
        public override void DealDamage(Hero hero) {
            hero.HealthPoints -= damage * bullets;
        }
    }

    class Fireball : Weapon {

        private int damage = 50;
        public override void DealDamage(Hero hero) {
            hero.HealthPoints -= damage;
        }
    }


    abstract class EnemyBossAi {
        public abstract string NextAction();
    }

    class IntroEnemyAi : EnemyBossAi {

        string[] actionsList = new string[3] {
            "playAnimationBow",
            "simpleAttack",
            "danceAnimation"
        };
        int currentAction = 0;
        public override string NextAction() {
            return actionsList[currentAction++];
        }
    }
    class AggressiveEnemyAi : EnemyBossAi {

        string[] actionsList = new string[4] {
            "attack",
            "rush",
            "attack",
            "callTeam",
        };
        int currentAction = 0;
        public override string NextAction() {
            return actionsList[currentAction++];
        }
    }

    class EnemyBoss {

        private EnemyBossAi ai;
        private Weapon weapon;

        public EnemyBoss(EnemyBossAi ai, Weapon weapon) {
            this.ai = ai;
            this.weapon = weapon; 
        }
        public EnemyBoss(AbstractFactoryEnemyBoss factory) {
            this.ai = factory.GetAi();
            this.weapon = factory.GetWeapon();
        }


        public string NextAction() {
            return this.ai.NextAction();
        }


        public void AttackHero(Hero hero) {
            this.weapon.DealDamage(hero);
        }

    }
}
