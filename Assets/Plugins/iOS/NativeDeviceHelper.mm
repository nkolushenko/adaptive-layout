#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

extern "C" {
    float GetNativeScreenScale() {
        return UIScreen.mainScreen.nativeScale;
    }
}
