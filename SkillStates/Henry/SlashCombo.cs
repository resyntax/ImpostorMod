using ImpostorMod.SkillStates.BaseStates;
using RoR2;
using UnityEngine;

namespace ImpostorMod.SkillStates
{
    public class SlashCombo : BaseMeleeAttack
    {
        public override void OnEnter()
        {
            this.hitboxName = "Sword";

            this.damageType = DamageType.Generic;
            this.damageCoefficient = Modules.StaticValues.swordDamageCoefficient;
            this.procCoefficient = 1f;
            this.pushForce = 100f;
            this.bonusForce = Vector3.zero;
            this.baseDuration = 1f;
            this.attackStartTime = 0.1f;
            this.attackEndTime = 0.3f;
            this.baseEarlyExitTime = 0.7f;
            this.hitStopDuration = 0.012f;
            this.attackRecoil = 1f;
            this.hitHopVelocity = 2f;

            this.swingSoundString = "HenrySwordSwing";
            this.hitSoundString = "";
            this.muzzleString = swingIndex % 2 == 0 ? "SwingLeft" : "SwingRight";
            this.swingEffectPrefab = Modules.Assets.swordSwingEffect;
            this.hitEffectPrefab = Modules.Assets.swordHitImpactEffect;

            this.impactSound = Modules.Assets.swordHitSoundEvent.index;

            base.OnEnter();
        }

        protected override void PlayAttackAnimation()
        {
            base.PlayAttackAnimation();
        }

        protected override void PlaySwingEffect()
        {
            base.PlaySwingEffect();
        }

        protected override void OnHitEnemyAuthority()
        {
            base.OnHitEnemyAuthority();
        }

        protected override void SetNextState()
        {
            int index = this.swingIndex;
            if (index == 0) index = 1;
            else index = 0;

            this.outer.SetNextState(new SlashCombo
            {
                swingIndex = index
            });
        }

        public override void OnExit()
        {
            base.OnExit();
        }
    }
}