# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'TalosMachineConfigApplyMode',
    'TalosMachineConfigVersion',
]


class TalosMachineConfigApplyMode(str, Enum):
    REBOOT = "REBOOT"
    """
    apply config with a reboot
    """
    AUTO = "AUTO"
    """
    automatically try to apply and reboot if only required
    """
    N_O_REBOOT = "NO_REBOOT"
    """
    apply config without a reboot
    """
    STAGED = "STAGED"
    """
    apply config as staged
    """


class TalosMachineConfigVersion(str, Enum):
    V1ALPHA1 = "v1alpha1"
    """
    Talos Machine Configuration Version
    """
